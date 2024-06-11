using OpenTK.Graphics.OpenGL;
using System;
using System.Drawing;
using System.Reflection.Emit;

namespace AgOpenGPS
{
    public class CTool
    {
        private readonly FormGPS mf;

        public double width, halfWidth, contourWidth;
        public double farLeftPosition = 0;
        public double farLeftSpeed = 0;
        public double farRightPosition = 0;
        public double farRightSpeed = 0;

        public double overlap;
        public double trailingHitchLength, tankTrailingHitchLength, trailingToolToPivotLength;
        public double offset;

        public double lookAheadOffSetting, lookAheadOnSetting;
        public double turnOffDelay;

        public double lookAheadDistanceOnPixelsLeft, lookAheadDistanceOnPixelsRight;
        public double lookAheadDistanceOffPixelsLeft, lookAheadDistanceOffPixelsRight;

        public bool isToolTrailing, isToolTBT;
        public bool isToolRearFixed, isToolFrontFixed;

        public bool isMultiColoredSections, isSectionOffWhenOut;
        public string toolAttachType;

        public double hitchLength;

        //how many individual sections
        public int numOfSections;

        //used for super section off on
        public int minCoverage;

        public bool areAllSectionBtnsOn = true;

        public bool isLeftSideInHeadland = true, isRightSideInHeadland = true, isSectionsNotZones;

        //read pixel values
        public int rpXPosition;

        public int rpWidth;

        private double textRotate;

        public Color[] secColors = new Color[16];

        public int zones;
        public int[] zoneRanges = new int[9];

        public bool isDisplayTramControl;

        #region My Stuff
        public byte productEnable = 0;
        public double targetRateGPA = 17;
        public double targetRateGPM = 0;
        public double targetRateGPMsum = 0;
        public double targetRailPressure = 0;
        public double railPressureRpt = 0;
        public double railFlowrateRpt = 0;
        public byte machineConfig = 1; // 1 = Planter, 2=Sprayer
        public int manualPumpCmd = 0;
        public byte numofRowModules = 5;
        public bool isRemoteConnected = false;
        public int moduleTimeout = 2;
        public int targetRegPos = 0;
        public int RegPosRpt = 0;
        public double targetPumpRPM = 0;
        public double PumpRPMRpt = 0;
        #endregion

        //Constructor called by FormGPS
        public CFold foldModule = new CFold();
        public CProductModule productModule = new CProductModule();
        public CRowModule[] rowModules;
        
        public CTool(FormGPS _f)
        {
            mf = _f;

            //from settings grab the vehicle specifics
            
            trailingToolToPivotLength = Properties.Settings.Default.setTool_trailingToolToPivotLength;
            width = Properties.Settings.Default.setVehicle_toolWidth;
            overlap = Properties.Settings.Default.setVehicle_toolOverlap;

            offset = Properties.Settings.Default.setVehicle_toolOffset;

            trailingHitchLength = Properties.Settings.Default.setTool_toolTrailingHitchLength;
            tankTrailingHitchLength = Properties.Settings.Default.setVehicle_tankTrailingHitchLength;
            hitchLength = Properties.Settings.Default.setVehicle_hitchLength;

            isToolRearFixed = Properties.Settings.Default.setTool_isToolRearFixed;
            isToolTrailing = Properties.Settings.Default.setTool_isToolTrailing;
            isToolTBT = Properties.Settings.Default.setTool_isToolTBT;
            isToolFrontFixed = Properties.Settings.Default.setTool_isToolFront;

            lookAheadOnSetting = Properties.Settings.Default.setVehicle_toolLookAheadOn;
            lookAheadOffSetting = Properties.Settings.Default.setVehicle_toolLookAheadOff;
            turnOffDelay = Properties.Settings.Default.setVehicle_toolOffDelay;

            isSectionOffWhenOut = Properties.Settings.Default.setTool_isSectionOffWhenOut;

            isSectionsNotZones = Properties.Settings.Default.setTool_isSectionsNotZones;

            if (isSectionsNotZones)
                numOfSections = Properties.Settings.Default.setVehicle_numSections;
            else
                numOfSections = Properties.Settings.Default.setTool_numSectionsMulti;

            minCoverage = Properties.Settings.Default.setVehicle_minCoverage;
            isMultiColoredSections = Properties.Settings.Default.setColor_isMultiColorSections;

            secColors[0] = Properties.Settings.Default.setColor_sec01.CheckColorFor255();
            secColors[1] = Properties.Settings.Default.setColor_sec02.CheckColorFor255();
            secColors[2] = Properties.Settings.Default.setColor_sec03.CheckColorFor255();
            secColors[3] = Properties.Settings.Default.setColor_sec04.CheckColorFor255();
            secColors[4] = Properties.Settings.Default.setColor_sec05.CheckColorFor255();
            secColors[5] = Properties.Settings.Default.setColor_sec06.CheckColorFor255();
            secColors[6] = Properties.Settings.Default.setColor_sec07.CheckColorFor255();
            secColors[7] = Properties.Settings.Default.setColor_sec08.CheckColorFor255();
            secColors[8] = Properties.Settings.Default.setColor_sec09.CheckColorFor255();
            secColors[9] = Properties.Settings.Default.setColor_sec10.CheckColorFor255();
            secColors[10] = Properties.Settings.Default.setColor_sec11.CheckColorFor255();
            secColors[11] = Properties.Settings.Default.setColor_sec12.CheckColorFor255();
            secColors[12] = Properties.Settings.Default.setColor_sec13.CheckColorFor255();
            secColors[13] = Properties.Settings.Default.setColor_sec14.CheckColorFor255();
            secColors[14] = Properties.Settings.Default.setColor_sec15.CheckColorFor255();
            secColors[15] = Properties.Settings.Default.setColor_sec16.CheckColorFor255();

            string[] words = Properties.Settings.Default.setTool_zones.Split(',');
            zones = int.Parse(words[0]);

            for (int i = 0; i < words.Length; i++)
            {
                zoneRanges[i] = int.Parse(words[i]);
            }

            isDisplayTramControl = Properties.Settings.Default.setTool_isDisplayTramControl;
            rowModules = new CRowModule[numofRowModules];
            for (int i = 0; i < numofRowModules; i++)
            {
                rowModules[i] = new CRowModule();
            }
        }

        #region Liquid
        public class CFold
        {

            public String version = "- - -";
            
            public byte hydFlowTarget = 0;
            public byte lhOuterWingRotate = 0;
            public byte lhWingRotate = 0;
            public byte lhWingLift = 0;
            public byte centerLift = 0;
            public byte rhWingLift = 0;
            public byte rhWingRotate = 0;
            public byte rhOuterWingRotate = 0;
            public byte autoBoomEnable = 0;
            public bool isJoystickConnected = false;
            public bool isFoldModuleConnected = false;
            public DateTime lastFoldMessageTimestamp = DateTime.UtcNow;
            public DateTime lastJoystickMessageTimestamp = DateTime.UtcNow;
            public int joystickTimeout = 2;
            public bool joystickEnabled = false;
            public byte joystickButton1 = 0;
            public byte joystickButton2 = 0;
            public CFold() { }

            
        }

        public class CRowModule
        {
            public bool isModuleConnected = false;
            public byte ipAddress = 0;
            public byte udpState = 0;
            
            public String version = "- - -";
            public DateTime lastMessageTimestamp = DateTime.UtcNow;
            public CRowModule() { }
            public bool checkStatus()
            {
                if ((DateTime.UtcNow - lastMessageTimestamp).TotalSeconds > 2)
                {
                    isModuleConnected = false;
                    return false;
                }
                else
                {
                    isModuleConnected = true;
                    return true;
                }
            }
        }

        public class CProductModule
        {
            public bool isModuleConnected = false;
            public byte ipAddress = 0;
            public byte udpState = 0;
            public DateTime lastMessageTimestamp = DateTime.UtcNow;
            public String version = "- - -";
            public double flowrateRpt = 0;
            
            public byte railPressureSensorState = 0;
            public CProductModule() { }

            public bool checkStatus()
            {
                if ((DateTime.UtcNow - lastMessageTimestamp).TotalSeconds > 2)
                {
                    isModuleConnected = false;
                    return false;
                } else
                {
                    isModuleConnected = true;
                    return true;
                }
            }
        }
        public void toolCmdSetup()
        {
            mf.p_151.pgn[mf.p_151.productEnable] = mf.tool.productEnable;
            
            //Send Fold Cmds//
            if (machineConfig == 2)
            {
                mf.p_150.pgn[mf.p_150.lhOuterWingRotate] = mf.tool.foldModule.lhOuterWingRotate;
                mf.p_150.pgn[mf.p_150.lhWingRotate] = mf.tool.foldModule.lhWingRotate;
                mf.p_150.pgn[mf.p_150.lhWingLift] = mf.tool.foldModule.lhWingLift;
                mf.p_150.pgn[mf.p_150.rhOuterWingRotate] = mf.tool.foldModule.rhOuterWingRotate;
                mf.p_150.pgn[mf.p_150.rhWingRotate] = mf.tool.foldModule.rhWingRotate;
                mf.p_150.pgn[mf.p_150.rhWingLift] = mf.tool.foldModule.rhWingLift;
                mf.p_150.pgn[mf.p_150.centerLift] = mf.tool.foldModule.centerLift;
                mf.SendPgnToLoop(mf.p_150.pgn);
            }
        }
        public void calculateToolFlowrate()
        {
            targetRateGPM = ((((mf.avgSpeed * 1000) / 60) * mf.tool.width) / 4046.856) * targetRateGPA;
            mf.p_151.pgn[mf.p_151.totalTargetRateHighByte] = unchecked((byte)((int)(targetRateGPM *100) >> 8));
            mf.p_151.pgn[mf.p_151.totalTargetRateLowByte] = unchecked((byte)((int)(targetRateGPM * 100)));
        }
        public void calculateToolPressure()
        {
            if (machineConfig == 2)
            {
                targetRailPressure = Math.Pow((targetRateGPM / 48), 2) * 275.51 - (targetRateGPM / 48) * 23.21 + 4.77;
                if (targetRailPressure < 10)
                {
                    targetRailPressure = 10;
                }
                mf.p_151.pgn[mf.p_151.totalPressureTargetHighByte] = unchecked((byte)((int)(targetRailPressure * 100) >> 8));
                mf.p_151.pgn[mf.p_151.totalPressureTargetLowByte] = unchecked((byte)((int)(targetRailPressure * 100)));
            }
            if (machineConfig == 1)
            {
                targetRailPressure = Math.Pow((targetRateGPM / 48), 2) * 275.51 - (targetRateGPM / 48) * 23.21 + 4.77;
                if (targetRailPressure < 10)
                {
                    targetRailPressure = 10;
                }
                mf.p_151.pgn[mf.p_151.totalPressureTargetHighByte] = unchecked((byte)((int)(targetRailPressure * 100) >> 8));
                mf.p_151.pgn[mf.p_151.totalPressureTargetLowByte] = unchecked((byte)((int)(targetRailPressure * 100)));
            }
        }
        public void calculateRegulatorPosition()
        {
            targetRegPos = (int)(targetRailPressure * 100);
            mf.p_151.pgn[mf.p_151.regulatorPositionTargetLowByte] = unchecked((byte)((int)(mf.tool.targetRegPos)));

            mf.p_151.pgn[mf.p_151.regulatorPositionTargetHighByte] = unchecked((byte)((int)(mf.tool.targetRegPos) >> 8));
        }
        public void calculatePumpRPM()
        {
            targetPumpRPM = 150;
            mf.p_151.pgn[mf.p_151.pumpRPMTargetLowByte] = unchecked((byte)((int)(targetPumpRPM)));
            mf.p_151.pgn[mf.p_151.pumpRPMTargetHighByte] = unchecked((byte)((int)(targetPumpRPM) >> 8));
        }
        public void calculateSectionFlowRate()
        {
            double pixelSpeedSum = 0;
            for (int i = 0; i < numOfSections; i++)
            {
                pixelSpeedSum += mf.section[i].speedPixels;
            }

            targetRateGPMsum = 0;
            for (int i = 0; i < numOfSections; i++)
            {
                if (pixelSpeedSum > 0 && mf.avgSpeed > 0)
                {
                    mf.section[i].sectionSpeed = (mf.section[i].speedPixels / (pixelSpeedSum / numOfSections)) * mf.avgSpeed;
                    mf.section[i].sectionTargetRate = ((((mf.section[i].sectionSpeed * 1000) / 60) * mf.section[i].sectionWidth) / 4046.856) * targetRateGPA;
                } else
                {
                    mf.section[i].sectionSpeed = 0;
                    mf.section[i].sectionTargetRate = 0;
                }

                if (mf.section[i].isSectionOn)
                {
                    targetRateGPMsum += mf.section[i].sectionTargetRate;
                }
                
            }
        }

        public void calculateSectionCmd()
        {
            if (machineConfig == 2)
            {
                mf.p_154.pgn[5] = 1;
                for (int i = 0; i < mf.tool.numOfSections; i++)
                {
                    if (mf.section[i].isSectionOn)
                    {
                        mf.p_154.pgn[i * 2 + 7] = 1;
                        mf.p_154.pgn[i * 2 + 8] = 1;
                    } else
                    {
                        mf.p_154.pgn[i * 2 + 7] = 0;
                        mf.p_154.pgn[i * 2 + 8] = 0;
                    }
                }
                //mf.SendPgnToLoop(mf.p_154.pgn);
            } 
            else if (machineConfig == 1)
            {
                // Send Duty Cycle Cmds// 
                mf.p_154.pgn[5] = (byte)(1);
                for (int i = 0; i < mf.tool.numOfSections; i++)
                {
                   
                   
                    if (mf.section[i].isSectionOn)
                    {
                        mf.section[i].sectionDutyTarget = mf.section[i].sectionSpeed * 100;
                        mf.p_154.pgn[i * 2 + 7] = unchecked((byte)((int)(mf.section[i].sectionDutyTarget) >> 8));
                        mf.p_154.pgn[i * 2 + 8] = unchecked((byte)((int)(mf.section[i].sectionDutyTarget)));
                    } else
                    {
                        mf.p_154.pgn[i * 2 + 7] = 0;
                        mf.p_154.pgn[i * 2 + 8] = 0;
                        mf.section[i].sectionDutyTarget = 0;
                    }
                }
                //mf.SendPgnToLoop(mf.p_154.pgn);
                // Send Frequency Cmds //
                mf.p_154.pgn[5] = (byte)(2);
                for (int i = 0; i < mf.tool.numOfSections; i++)
                {
                    if (mf.section[i].isSectionOn)
                    {
                        mf.p_154.pgn[i * 2 + 7] = unchecked((byte)((int)(mf.section[i].sectionDutyTarget) >> 8));
                        mf.p_154.pgn[i * 2 + 8] = unchecked((byte)((int)(mf.section[i].sectionDutyTarget)));
                    }
                    else
                    {
                        mf.p_154.pgn[i * 2 + 7] = 0;
                        mf.p_154.pgn[i * 2 + 8] = 0;
                    }
                }
                //mf.SendPgnToLoop(mf.p_154.pgn);
            }
        }
        
        #endregion

        public void DrawTool()
        {
            //translate and rotate at pivot axle
            GL.Translate(mf.pivotAxlePos.easting, mf.pivotAxlePos.northing, 0);
            GL.PushMatrix();

            //translate down to the hitch pin
            GL.Translate(Math.Sin(mf.fixHeading) * (hitchLength),
                            Math.Cos(mf.fixHeading) * (hitchLength), 0);

            //settings doesn't change trailing hitch length if set to rigid, so do it here
            double trailingTank, trailingTool;
            if (isToolTrailing)
            {
                trailingTank = tankTrailingHitchLength;
                trailingTool = trailingHitchLength;
            }
            else { trailingTank = 0; trailingTool = 0; }

            //there is a trailing tow between hitch
            if (isToolTBT && isToolTrailing)
            {
                //rotate to tank heading
                GL.Rotate(glm.toDegrees(-mf.tankPos.heading), 0.0, 0.0, 1.0);

                //draw the tank hitch
                GL.LineWidth(6);
                //draw the rigid hitch
                GL.Color3(0, 0, 0);
                GL.Begin(PrimitiveType.LineLoop);
                GL.Vertex3(-0.57, trailingTank, 0);
                GL.Vertex3(0, 0, 0);
                GL.Vertex3(0.57, trailingTank, 0);

                GL.End();

                GL.LineWidth(1);
                //draw the rigid hitch
                GL.Color3(0.765f, 0.76f, 0.32f);
                GL.Begin(PrimitiveType.LineLoop);
                GL.Vertex3(-0.57, trailingTank, 0);
                GL.Vertex3(0, 0, 0);
                GL.Vertex3(0.57, trailingTank, 0);

                GL.End();

                //GL.LineWidth(4);
                //GL.Color3(0.937f, 0.537f, 0.397f);
                //GL.Begin(PrimitiveType.Lines);
                //GL.Vertex3(0, trailingTank, 0);
                //GL.Vertex3(0, 0, 0);
                //GL.End();

                //GL.Color3(0.937f, 0.537f, 0.397f);
                //GL.Begin(PrimitiveType.Lines);
                //GL.Vertex3(-1, trailingTank, 0);
                //GL.Vertex3(1, trailingTank, 0);
                //GL.End();

                //pivot markers
                //GL.Color3(0,0,0);
                //GL.PointSize(8);
                //GL.Begin(PrimitiveType.Points);
                //GL.Vertex3(-1, trailingTank, 0.0);
                //GL.Vertex3(1, trailingTank, 0.0);
                //GL.End();

                    GL.Enable(EnableCap.Texture2D);
                    GL.Color4(1, 1, 1, 0.75);
                    GL.BindTexture(TextureTarget.Texture2D, mf.texture[(int)FormGPS.textures.ToolWheels]);        // Select Our Texture
                    GL.Begin(PrimitiveType.TriangleStrip);              // Build Quad From A Triangle Strip
                    GL.TexCoord2(1, 0); GL.Vertex2(1.5, trailingTank + 1); // Top Right
                    GL.TexCoord2(0, 0); GL.Vertex2(-1.5, trailingTank + 1); // Top Left
                    GL.TexCoord2(1, 1); GL.Vertex2(1.5, trailingTank - 1); // Bottom Right
                    GL.TexCoord2(0, 1); GL.Vertex2(-1.5, trailingTank - 1); // Bottom Left
                    GL.End();                       // Done Building Triangle Strip
                    GL.Disable(EnableCap.Texture2D);


                //move down the tank hitch, unwind, rotate to section heading
                GL.Translate(0.0, trailingTank, 0.0);
                GL.Rotate(glm.toDegrees(mf.tankPos.heading), 0.0, 0.0, 1.0);
                GL.Rotate(glm.toDegrees(-mf.toolPivotPos.heading), 0.0, 0.0, 1.0);
            }

            //no tow between hitch
            else
            {
                GL.Rotate(glm.toDegrees(-mf.toolPivotPos.heading), 0.0, 0.0, 1.0);
            }

            //draw the hitch if trailing
            if (isToolTrailing)
            {
                GL.LineWidth(6);
                GL.Color3(0, 0, 0);
                GL.Begin(PrimitiveType.LineLoop);
                GL.Vertex3(-0.65 + mf.tool.offset, trailingTool, 0);
                GL.Vertex3(0, 0, 0);
                GL.Vertex3(0.65 + mf.tool.offset, trailingTool, 0);

                GL.End();

                GL.LineWidth(1);
                //draw the rigid hitch
                GL.Color3(0.7f, 0.4f, 0.2f);
                GL.Begin(PrimitiveType.LineLoop);
                GL.Vertex3(-0.65 + mf.tool.offset, trailingTool, 0);
                GL.Vertex3(0, 0, 0);
                GL.Vertex3(0.65 + mf.tool.offset, trailingTool, 0);

                GL.End();

                if (Math.Abs(trailingToolToPivotLength) > 1 && mf.camera.camSetDistance > -100)
                {
                    textRotate += (mf.sim.stepDistance);
                    GL.Enable(EnableCap.Texture2D);
                    GL.Color4(1, 1, 1, 0.75);
                    GL.BindTexture(TextureTarget.Texture2D, mf.texture[(int)FormGPS.textures.Tire]);        // Select Our Texture
                    GL.Begin(PrimitiveType.TriangleStrip);              // Build Quad From A Triangle Strip
                    GL.TexCoord2(1, 0 + textRotate); GL.Vertex2(1.4 + offset, trailingTool + 0.51); // Top Right
                    GL.TexCoord2(0, 0 + textRotate); GL.Vertex2(0.75 + offset, trailingTool + 0.51); // Top Left
                    GL.TexCoord2(1, 1 + textRotate); GL.Vertex2(1.4 + offset, trailingTool - 0.51); // Bottom Right
                    GL.TexCoord2(0, 1 + textRotate); GL.Vertex2(0.75 + offset, trailingTool - 0.51); // Bottom Left
                    GL.End();                       // Done Building Triangle Strip
                    GL.Begin(PrimitiveType.TriangleStrip);              // Build Quad From A Triangle Strip
                    GL.TexCoord2(1, 0 + textRotate); GL.Vertex2(-1.4 + offset, trailingTool + 0.51); // Top Right
                    GL.TexCoord2(0, 0 + textRotate); GL.Vertex2(-0.75 + offset, trailingTool + 0.51); // Top Left
                    GL.TexCoord2(1, 1 + textRotate); GL.Vertex2(-1.4 + offset, trailingTool - 0.51); // Bottom Right
                    GL.TexCoord2(0, 1 + textRotate); GL.Vertex2(-0.75 + offset, trailingTool - 0.51); // Bottom Left
                    GL.End();                       // Done Building Triangle Strip
                    GL.Disable(EnableCap.Texture2D);
                }
                //if (Math.Abs(trailingToolToPivotLength) > 1)
                //{
                //    textRotate += mf.sim.stepDistance;
                //    GL.Enable(EnableCap.Texture2D);
                //    GL.Color4(1, 1, 1, 0.75);
                //    GL.BindTexture(TextureTarget.Texture2D, mf.texture[26]);        // Select Our Texture
                //    GL.Begin(PrimitiveType.TriangleStrip);              // Build Quad From A Triangle Strip
                //    GL.TexCoord2(1, 0 + textRotate); GL.Vertex2(1.5 + offset, trailingTool + 1); // Top Right
                //    GL.TexCoord2(0, 0 + textRotate); GL.Vertex2(-1.5 + offset, trailingTool + 1); // Top Left
                //    GL.TexCoord2(1, 1 + textRotate); GL.Vertex2(1.5 + offset, trailingTool - 1); // Bottom Right
                //    GL.TexCoord2(0, 1 + textRotate); GL.Vertex2(-1.5 + offset, trailingTool - 1); // Bottom Left
                //    GL.End();                       // Done Building Triangle Strip
                //    GL.Disable(EnableCap.Texture2D);
                //}

                trailingTool -= trailingToolToPivotLength;
            }

            if (mf.isJobStarted)
            {
                //look ahead lines
                GL.LineWidth(1);
                GL.Begin(PrimitiveType.Lines);

                //lookahead section on
                GL.Color3(0.20f, 0.7f, 0.2f);
                GL.Vertex3(mf.tool.farLeftPosition, (mf.tool.lookAheadDistanceOnPixelsLeft) * 0.1 + trailingTool, 0);
                GL.Vertex3(mf.tool.farRightPosition, (mf.tool.lookAheadDistanceOnPixelsRight) * 0.1 + trailingTool, 0);

                //lookahead section off
                GL.Color3(0.70f, 0.2f, 0.2f);
                GL.Vertex3(mf.tool.farLeftPosition, (mf.tool.lookAheadDistanceOffPixelsLeft) * 0.1 + trailingTool, 0);
                GL.Vertex3(mf.tool.farRightPosition, (mf.tool.lookAheadDistanceOffPixelsRight) * 0.1 + trailingTool, 0);

                if (mf.vehicle.isHydLiftOn)
                {
                    GL.Color3(0.70f, 0.2f, 0.72f);
                    GL.Vertex3(mf.section[0].positionLeft, (mf.vehicle.hydLiftLookAheadDistanceLeft * 0.1) + trailingTool, 0);
                    GL.Vertex3(mf.section[mf.tool.numOfSections - 1].positionRight, (mf.vehicle.hydLiftLookAheadDistanceRight * 0.1) + trailingTool, 0);
                }

                GL.End();
            }
            //draw the sections
            GL.LineWidth(2);

            double hite = mf.camera.camSetDistance / -200;
            if (hite > 0.5) hite = 0.5;
            if (hite < 0.3) hite = 0.3;

            {
                for (int j = 0; j < numOfSections; j++)
                {
                    //if section is on, green, if off, red color
                    if (mf.section[j].isSectionOn)
                    {
                        if (mf.section[j].sectionBtnState == btnStates.Auto)
                        {
                            //GL.Color3(0.0f, 0.9f, 0.0f);
                            if (mf.section[j].isMappingOn) GL.Color3(0.0f, 0.95f, 0.0f);
                            else GL.Color3(0.970f, 0.30f, 0.970f);
                        }
                        else GL.Color3(0.97, 0.97, 0);
                    }
                    else
                    {
                        if (!mf.section[j].isMappingOn) GL.Color3(0.950f, 0.2f, 0.2f);
                        else GL.Color3(0.00f, 0.250f, 0.97f);
                        //GL.Color3(0.7f, 0.2f, 0.2f);
                    }

                    double mid = (mf.section[j].positionRight - mf.section[j].positionLeft) / 2 + mf.section[j].positionLeft;

                    GL.Begin(PrimitiveType.TriangleFan);
                    {
                        GL.Vertex3(mf.section[j].positionLeft, trailingTool, 0);
                        GL.Vertex3(mf.section[j].positionLeft, trailingTool - hite, 0);

                        GL.Vertex3(mid, trailingTool - hite * 1.5, 0);

                        GL.Vertex3(mf.section[j].positionRight, trailingTool - hite, 0);
                        GL.Vertex3(mf.section[j].positionRight, trailingTool, 0);
                    }
                    GL.End();

                    if (mf.camera.camSetDistance > -150)
                    {
                        GL.Begin(PrimitiveType.LineLoop);
                        {
                            GL.Color3(0.0, 0.0, 0.0);
                            GL.Vertex3(mf.section[j].positionLeft, trailingTool, 0);
                            GL.Vertex3(mf.section[j].positionLeft, trailingTool - hite, 0);

                            GL.Vertex3(mid, trailingTool - hite * 1.5, 0);

                            GL.Vertex3(mf.section[j].positionRight, trailingTool - hite, 0);
                            GL.Vertex3(mf.section[j].positionRight, trailingTool, 0);
                        }
                        GL.End();
                    }
                }

                //zones

                if (!isSectionsNotZones && zones > 0 && mf.camera.camSetDistance > -150)
                {
                    //GL.PointSize(8);

                    GL.Begin(PrimitiveType.Lines);
                    for (int i = 1; i < zones; i++)
                    {
                        GL.Color3(0.5f, 0.80f, 0.950f);
                        GL.Vertex3(mf.section[zoneRanges[i]].positionLeft, trailingTool - 0.4, 0);
                        GL.Vertex3(mf.section[zoneRanges[i]].positionLeft, trailingTool + 0.2, 0);
                    }

                    GL.End();
                }

                //tram Dots
                if (isDisplayTramControl && mf.tram.displayMode != 0)
                {
                    if (mf.camera.camSetDistance > -300)
                    {
                        if (mf.camera.camSetDistance > -100)
                            GL.PointSize(12);
                        else GL.PointSize(8);

                        if (mf.tram.isOuter)
                        {
                            //section markers
                            GL.Begin(PrimitiveType.Points);

                            //right side
                            if (((mf.tram.controlByte) & 1) == 1) GL.Color3(0.0f, 0.900f, 0.39630f);
                            else GL.Color3(0, 0, 0);
                            GL.Vertex3(farRightPosition - mf.tram.halfWheelTrack, trailingTool, 0);

                            //left side
                            if ((mf.tram.controlByte & 2) == 2) GL.Color3(0.0f, 0.900f, 0.3930f);
                            else GL.Color3(0, 0, 0);
                            GL.Vertex3(farLeftPosition + mf.tram.halfWheelTrack, trailingTool, 0);
                            GL.End();
                        }
                        else
                        {
                            GL.Begin(PrimitiveType.Points);

                            //right side
                            if (((mf.tram.controlByte) & 1) == 1) GL.Color3(0.0f, 0.900f, 0.39630f);
                            else GL.Color3(0, 0, 0);
                            GL.Vertex3(mf.tram.halfWheelTrack, trailingTool, 0);

                            //left side
                            if ((mf.tram.controlByte & 2) == 2) GL.Color3(0.0f, 0.900f, 0.3930f);
                            else GL.Color3(0, 0, 0);
                            GL.Vertex3(-mf.tram.halfWheelTrack, trailingTool, 0);
                            GL.End();
                        }
                    }
                }
            }

            //GL.End();

            //draw section markers if close enough
            //if (mf.camera.camSetDistance > -250)
            //{
            //    GL.Color3(0.0f, 0.0f, 0.0f);
            //    //section markers
            //    GL.PointSize(3.0f);
            //    GL.Begin(PrimitiveType.Points);
            //    for (int j = 0; j < numOfSections - 1; j++)
            //        GL.Vertex3(mf.section[j].positionRight, trailingTool, 0);
            //    GL.End();
            //}

            //GL.Color3(0.30f, 1.0f, 1.0f);
            ////section markers
            //GL.PointSize(4.0f);
            //GL.Begin(PrimitiveType.Points);
            ////for (int j = 0; j < numOfSections - 1; j++)
            //GL.Vertex3(mf.section[0].positionLeft, (mf.vehicle.hydLiftLookAheadDistanceLeft * 0.1) + trailingTool, 0);
            //GL.Vertex3(mf.section[mf.tool.numOfSections - 1].positionRight, (mf.vehicle.hydLiftLookAheadDistanceRight * 0.1) + trailingTool, 0);
            //GL.End();

            GL.PopMatrix();
        }
    }
}