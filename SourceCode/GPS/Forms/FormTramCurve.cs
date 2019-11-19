﻿using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace AgOpenGPS
{
    public partial class FormTramCurve : Form
    {
        //access to the main GPS form and all its variables
        private readonly FormGPS mf = null;

        private double snapAdj = 0;

        public FormTramCurve(Form callingForm)
        {
            //get copy of the calling main form
            mf = callingForm as FormGPS;

            InitializeComponent();

            this.Text = gStr.gsTramLines;               

            nudWheelSpacing.Controls[0].Enabled = false;
            nudSnapAdj.Controls[0].Enabled = false;
            nudEqWidth.Controls[0].Enabled = false;
            nudPasses.Controls[0].Enabled = false;
            nudOffset.Controls[0].Enabled = false;
        }

        private void FormTram_Load(object sender, EventArgs e)
        { 
            mf.ABLine.tramWidth = Properties.Settings.Default.setTram_eqWidth;
            mf.ABLine.tramWheelSpacing = Properties.Settings.Default.setTram_wheelSpacing;
            mf.ABLine.tramPasses = Properties.Settings.Default.setTram_passes;
            mf.ABLine.tramOffset = Properties.Settings.Default.setTram_offset;

            nudSnapAdj.Value = (decimal)((mf.vehicle.toolWidth - mf.vehicle.toolOffset)/2.0);
            nudEqWidth.Value = (decimal)Properties.Settings.Default.setTram_eqWidth;
            nudWheelSpacing.Value = (decimal)Properties.Settings.Default.setTram_wheelSpacing;
            nudPasses.Value = Properties.Settings.Default.setTram_passes;
            nudOffset.Value = (decimal)Properties.Settings.Default.setTram_offset;

            mf.curve.BuildTram();
            mf.curve.isEditing = true;
            mf.layoutPanelRight.Enabled = false;

            this.Left = mf.Width - 430;
            this.Top = 100;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //mf.ABLine.moveDistance = 0;
            mf.curve.isEditing = false;
            mf.layoutPanelRight.Enabled = true;

            mf.offX = 0;
            mf.offY = 0;
            if (mf.curve.refList.Count > 0)
            {
                //array number is 1 less since it starts at zero
                int idx = mf.curve.numCurveLineSelected - 1;

                //mf.curve.curveArr[idx].Name = textBox1.Text.Trim();
                if (idx >= 0)
                {
                    mf.curve.curveArr[idx].aveHeading = mf.curve.aveLineHeading;
                    mf.curve.curveArr[idx].curvePts.Clear();
                    //write out the Curve Points
                    foreach (var item in mf.curve.refList)
                    {
                        mf.curve.curveArr[idx].curvePts.Add(item);
                    }
                }

                //save entire list
                mf.FileSaveCurveLines();
                mf.curve.moveDistance = 0;
            }

            Close();

        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            double dist = 0.1;
            mf.curve.MoveABCurve(-dist);
            mf.curve.BuildTram();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            double dist = 0.1;
            mf.curve.MoveABCurve(dist);
            mf.curve.BuildTram();
        }

        private void btnLeftFullWidth_Click(object sender, EventArgs e)
        {
            double dist = mf.vehicle.toolWidth - mf.vehicle.toolOverlap;

            mf.curve.MoveABCurve(-dist);
            mf.curve.BuildTram();

        }

        private void btnRightFullWidth_Click(object sender, EventArgs e)
        {
            double dist = mf.vehicle.toolWidth - mf.vehicle.toolOverlap;

            mf.curve.MoveABCurve(dist);
            mf.curve.BuildTram();
        }

        private void btnAdjLeft_Click(object sender, EventArgs e)
        {
            mf.curve.MoveABCurve(-snapAdj);
            mf.curve.BuildTram();
        }

        private void btnAdjRight_Click(object sender, EventArgs e)
        {
            mf.curve.MoveABCurve(snapAdj);
            mf.curve.BuildTram();
        }

        private void nudSnapAdj_Enter(object sender, EventArgs e)
        {
            mf.KeypadToNUD((NumericUpDown)sender);
            btnCancel.Focus();
        }

        private void nudPasses_ValueChanged(object sender, EventArgs e)
        {
            mf.ABLine.tramPasses = (int)nudPasses.Value;
            Properties.Settings.Default.setTram_passes = mf.ABLine.tramPasses;
            Properties.Settings.Default.Save();
            mf.curve.BuildTram();
        }

        private void nudPasses_Enter(object sender, EventArgs e)
        {
            mf.KeypadToNUD((NumericUpDown)sender);
            btnCancel.Focus();
        }

        private void nudOffset_ValueChanged(object sender, EventArgs e)
        {
            mf.ABLine.tramOffset = (double)nudOffset.Value;
            Properties.Settings.Default.setTram_offset = mf.ABLine.tramOffset;
            Properties.Settings.Default.Save();
            mf.curve.BuildTram();
        }

        private void nudOffset_Enter(object sender, EventArgs e)
        {
            mf.KeypadToNUD((NumericUpDown)sender);
            btnCancel.Focus();
        }

        private void btnSwapAB_Click(object sender, EventArgs e)
        {
            int cnt = mf.curve.refList.Count;
            if (cnt > 0)
            {
                mf.curve.refList.Reverse();

                vec3[] arr = new vec3[cnt];
                cnt--;
                mf.curve.refList.CopyTo(arr);
                mf.curve.refList.Clear();

                mf.curve.aveLineHeading += Math.PI;
                if (mf.curve.aveLineHeading < 0) mf.curve.aveLineHeading += glm.twoPI;
                if (mf.curve.aveLineHeading > glm.twoPI) mf.curve.aveLineHeading -= glm.twoPI;

                for (int i = 1; i < cnt; i++)
                {
                    vec3 pt3 = arr[i];
                    pt3.heading += Math.PI;
                    if (pt3.heading > glm.twoPI) pt3.heading -= glm.twoPI;
                    if (pt3.heading < 0) pt3.heading += glm.twoPI;
                    mf.curve.refList.Add(pt3);
                }
            }
            mf.curve.BuildTram();
        }

        private void btnTriggerDistanceUp_MouseDown(object sender, MouseEventArgs e)
        {
            nudPasses.UpButton();
            mf.curve.BuildTram();
        }

        private void btnTriggerDistanceDn_MouseDown(object sender, MouseEventArgs e)
        {
            nudPasses.DownButton();
            mf.curve.BuildTram();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mf.curve.tramArr?.Clear();
            mf.curve.isEditing = false;
            mf.layoutPanelRight.Enabled = true;
            mf.offX = 0;
            mf.offY = 0;
            Close();
        }

        private void btnZoomOut_MouseDown(object sender, MouseEventArgs e)
        {
            if (mf.camera.zoomValue <= 20)
            { if ((mf.camera.zoomValue -= mf.camera.zoomValue * 0.1) < 6.0) mf.camera.zoomValue = 6.0; }
            else { if ((mf.camera.zoomValue -= mf.camera.zoomValue * 0.05) < 6.0) mf.camera.zoomValue = 6.0; }
            mf.camera.camSetDistance = mf.camera.zoomValue * mf.camera.zoomValue * -1;
            mf.SetZoom();
        }

        private void btnZoomIn_MouseDown(object sender, MouseEventArgs e)
        {
            if (mf.camera.zoomValue <= 20) mf.camera.zoomValue += mf.camera.zoomValue * 0.1;
            else mf.camera.zoomValue += mf.camera.zoomValue * 0.05;
            if (mf.camera.zoomValue > 220) mf.camera.zoomValue = 220;
            mf.camera.camSetDistance = mf.camera.zoomValue * mf.camera.zoomValue * -1;
           mf.SetZoom();

        }

        private void btnMoveDown_MouseDown(object sender, MouseEventArgs e)
        {
            mf.offX += (Math.Sin(mf.fixHeading) * 10);
            mf.offY += (Math.Cos(mf.fixHeading) * 10);
        }

        private void btnMoveUp_MouseDown(object sender, MouseEventArgs e)
        {
            mf.offX -= (Math.Sin(mf.fixHeading) * 10);
            mf.offY -= (Math.Cos(mf.fixHeading) * 10);
        }

        private void btnMoveLeft_MouseDown(object sender, MouseEventArgs e)
        {
            mf.offY += (Math.Sin(-mf.fixHeading) * 10);
            mf.offX += (Math.Cos(-mf.fixHeading) * 10);
        }

        private void btnMoveRight_MouseDown(object sender, MouseEventArgs e)
        {
            mf.offY -= (Math.Sin(-mf.fixHeading) * 10);
            mf.offX -= (Math.Cos(-mf.fixHeading) * 10);
        }

        private void btnResetDrag_Click(object sender, EventArgs e)
        {
            mf.offX = 0;
            mf.offY = 0;
        }

        private void nudSnapAdj_ValueChanged(object sender, EventArgs e)
        {
            snapAdj = (double)nudSnapAdj.Value;
            Properties.Settings.Default.setTram_snapAdj = snapAdj;
            Properties.Settings.Default.Save();
            mf.curve.BuildTram();
        }

        private void nudEqWidth_ValueChanged(object sender, EventArgs e)
        {
            mf.ABLine.tramWidth  = (double)nudEqWidth.Value;
            Properties.Settings.Default.setTram_eqWidth = mf.ABLine.tramWidth;
            Properties.Settings.Default.Save();
            mf.curve.BuildTram();

        }

        private void nudEqWidth_Enter(object sender, EventArgs e)
        {
            mf.KeypadToNUD((NumericUpDown)sender);
            btnCancel.Focus();
        }

        private void nudWheelSpacing_ValueChanged(object sender, EventArgs e)
        {
            mf.ABLine.tramWheelSpacing = (double)nudWheelSpacing.Value;
            Properties.Settings.Default.setTram_wheelSpacing = mf.ABLine.tramWheelSpacing;
            Properties.Settings.Default.Save();
            mf.curve.BuildTram();
        }

        private void nudWheelSpacing_Enter(object sender, EventArgs e)
        {
            mf.KeypadToNUD((NumericUpDown)sender);
            btnCancel.Focus();        
        }

    }
}