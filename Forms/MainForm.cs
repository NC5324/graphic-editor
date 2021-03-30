using CourseProject.Gfx;
using CourseProject.Tools;
using CourseProject.Forms;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class MainForm : Form
    {
        #region Private Members
        private string _saveTarget;
        private int _copyTargetCount;

        private WelcomeForm welcomeForm = new WelcomeForm();
        private List<IGraphic> Clipboard = new List<IGraphic>();
        #endregion Private Members

        public MainForm()
        {
            InitializeComponent();

            clrDialogOutline.Color = Color.Black;
            clrDialogFill.Color = Color.Empty;
        }

        #region Tool Selection
        private void btnOutlineColor_Click(object sender, EventArgs e)
        {
            clrDialogOutline.ShowDialog();
            canvasView1.Canvas.OutlineColor = clrDialogOutline.Color;
            btnOutlineColor.BackColor = clrDialogOutline.Color;

            BucketTool.GetInstance().OutlineColor = canvasView1.Canvas.OutlineColor;
        }

        private void btnFillColor_Click(object sender, EventArgs e)
        {
            clrDialogFill.ShowDialog();
            canvasView1.Canvas.FillColor = clrDialogFill.Color;
            btnFillColor.BackColor = clrDialogFill.Color;

            BucketTool.GetInstance().FillColor = canvasView1.Canvas.FillColor;
        }
        private void btnEnableGrid_Click(object sender, EventArgs e)
        {
            canvasView1.Canvas.SnapToGrid = !canvasView1.Canvas.SnapToGrid;
            canvasView1.Canvas.Invalidate();
            if (canvasView1.Canvas.SnapToGrid)
                btnEnableGrid.BackgroundImage = Properties.Resources.grid_disable;
            else
                btnEnableGrid.BackgroundImage = Properties.Resources.grid_enable;
        }

        private void btnShowGrid_Click_1(object sender, EventArgs e)
        {
            canvasView1.Canvas.ShowGrid = !canvasView1.Canvas.ShowGrid;
            canvasView1.Canvas.Invalidate();
            if (canvasView1.Canvas.ShowGrid)
                btnShowGrid.BackgroundImage = Properties.Resources.grid_hide;
            else
                btnShowGrid.BackgroundImage = Properties.Resources.grid_show;
        }
        private void btnPan_Click(object sender, EventArgs e)
        {
            canvasView1.Canvas.Tool = PanningTool.GetInstance();
        }

        private void btnShowGrid_Click(object sender, EventArgs e)
        {
            canvasView1.Canvas.ShowGrid = !canvasView1.Canvas.ShowGrid;
            canvasView1.Canvas.Invalidate();
        }

        private void btnSelection_Click(object sender, EventArgs e)
        {
            canvasView1.Canvas.Tool = ToolFactory.GetInstance<SelectionTool>();
        }

        private void btnMagnifier_Click(object sender, EventArgs e)
        {
            canvasView1.Canvas.Tool = ToolFactory.GetInstance<MagnifierTool>();
        }

        private void btnPointer_Click(object sender, EventArgs e)
        {
            //canvasView1.Canvas.Tool = ToolFactory.GetInstance<Pointer>();
            canvasView1.Canvas.Tool = Tools.Pointer.GetInstance();
        }

        private void btnScribble_Click(object sender, EventArgs e)
        {
            canvasView1.Canvas.Tool = ToolFactory.GetInstance<Pencil>();
        }

        private void btnOval_Click(object sender, EventArgs e)
        {
            canvasView1.Canvas.Tool = ToolFactory.GetInstance<Oval>();
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            canvasView1.Canvas.Tool = ToolFactory.GetInstance<Triangle>();
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            canvasView1.Canvas.Tool = ToolFactory.GetInstance<CourseProject.Gfx.Rectangle>();
        }

        private void btnParallelogram_Click(object sender, EventArgs e)
        {
            canvasView1.Canvas.Tool = ToolFactory.GetInstance<Parallelogram>();
        }

        private void btnPentagon_Click(object sender, EventArgs e)
        {
            canvasView1.Canvas.Tool = ToolFactory.GetInstance<Pentagon>();
        }

        private void btnHexagon_Click(object sender, EventArgs e)
        {
            canvasView1.Canvas.Tool = ToolFactory.GetInstance<Hexagon>();
        }

        private void btnHeptagon_Click(object sender, EventArgs e)
        {
            canvasView1.Canvas.Tool = ToolFactory.GetInstance<Heptagon>();
        }

        private void btnOctagon_Click(object sender, EventArgs e)
        {
            canvasView1.Canvas.Tool = ToolFactory.GetInstance<Octagon>();
        }

        private void btnSwitchColors_Click(object sender, EventArgs e)
        {
            var temp = canvasView1.Canvas.OutlineColor;
            canvasView1.Canvas.OutlineColor = canvasView1.Canvas.FillColor;

            canvasView1.Canvas.FillOpacity = (int)updownFillOpacity.Value;
            canvasView1.Canvas.FillColor = temp;

            btnOutlineColor.BackColor = canvasView1.Canvas.OutlineColor;
            btnFillColor.BackColor = canvasView1.Canvas.FillColor;
        }
        private void btnImageTool_Click(object sender, EventArgs e)
        {
            canvasView1.Canvas.Tool = ImageTool.GetInstance();
        }

        private void btnText_Click(object sender, EventArgs e)
        {
            canvasView1.Canvas.Tool = TextTool.GetInstance();
        }

        private void btnEraser_Click(object sender, EventArgs e)
        {
            canvasView1.Canvas.Tool = ToolFactory.GetInstance<Eraser>();
        }

        private BucketToolOptions options;
        private void btnBucket_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                canvasView1.Canvas.Tool = BucketTool.GetInstance(canvasView1.Canvas.OutlineColor, canvasView1.Canvas.FillColor, true, true);
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (options == null)
                    options = new BucketToolOptions();

                options.ShowDialog();
                canvasView1.Canvas.Tool = BucketTool.GetInstance(options.OutlineColor, options.FillColor, options.OutlineEnabled, options.FillEnabled);
            }
        }

        private void updownOutlineWidth_ValueChanged(object sender, EventArgs e)
        {
            canvasView1.Canvas.OutlineWidth = (int)updownOutlineWidth.Value;
        }
        #endregion

        #region ToolStrip Menu

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile(true);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFile();
        }

        #endregion

        #region User Interface Stuff
        private void btnMisc_Click(object sender, EventArgs e)
        {
            splitEast_Top.Panel1Collapsed = !splitEast_Top.Panel1Collapsed;
        }

        private void btnShapes_Click(object sender, EventArgs e)
        {
            splitEast_Top.Panel2Collapsed = !splitEast_Top.Panel2Collapsed;
        }

        private void btnLayers_Click(object sender, EventArgs e)
        {
            splitEast_Bot.Panel1Collapsed = !splitEast_Bot.Panel1Collapsed;
        }

        private void btnProperties_Click(object sender, EventArgs e)
        {
            splitEast_Bot.Panel2Collapsed = !splitEast_Bot.Panel2Collapsed;
        }
        private void btnTools_Click(object sender, EventArgs e)
        {
            splitContainer4.Panel1Collapsed = !splitContainer4.Panel1Collapsed;
        }
        #endregion

        #region Layer Manager
        private void layerManager_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            var layers = canvasView1.Canvas.Layers;
            var layer = layers[e.RowIndex];
            canvasView1.Canvas.SelectedLayer = layer;

            switch (e.ColumnIndex)
            {
                case 1:
                    canvasView1.Canvas.Layers.MoveUp(layer);
                    UpdateLayerManager();
                    break;
                case 2:
                    canvasView1.Canvas.Layers.MoveDown(layer);
                    UpdateLayerManager();
                    break;
                case 3:
                    layers[layer].Visible = !layers[layer].Visible;
                    UpdateLayerManager();
                    break;
                case 4:
                    layers[layer].Locked = !layers[layer].Locked;
                    UpdateLayerManager();
                    break;
            }
            canvasView1.Canvas.Invalidate();
        }

        private void btnRenameLayer_Click(object sender, EventArgs e)
        {
            using (LayerRenameDialog dg = new LayerRenameDialog())
            {
                dg.ShowDialog();
                if (dg.DialogResult == DialogResult.OK)
                {
                    canvasView1.Canvas.Layers[canvasView1.Canvas.SelectedLayer].Name = dg.LayerName;
                    UpdateLayerManager();
                }
            }
        }

        private void btnAddLayer_Click(object sender, EventArgs e)
        {
            var layer = new Layer();
            canvasView1.Canvas.Layers.Add(layer);
            canvasView1.Canvas.SelectedLayer = layer;
            UpdateLayerManager();
        }

        private void btnRemoveLayer_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            foreach (DataGridViewRow r in layerManager.Rows)
            {
                if (r.Selected)
                {
                    row = r;
                    break;
                }
            }

            var v = row.Index;
            canvasView1.Canvas.Layers.Remove(canvasView1.Canvas.Layers[v]);
            canvasView1.Canvas.SelectedLayer = canvasView1.Canvas.Layers[v - 1];
            UpdateLayerManager();
        }
        private void UpdateLayerManager()
        {
            bindingSource1.DataSource = null;
            bindingSource1.DataSource = canvasView1.Canvas.Layers;
            layerManager.DataSource = bindingSource1;

            foreach (DataGridViewRow row in layerManager.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.ColumnIndex == 0)
                    {
                        cell.Value = canvasView1.Canvas.Layers[canvasView1.Canvas.Layers[cell.RowIndex]].Name;
                    }
                    else if (cell.ColumnIndex == 3)
                    {
                        cell.Value = canvasView1.Canvas.Layers[canvasView1.Canvas.Layers[cell.RowIndex]].Visible ? Properties.Resources.invisible : Properties.Resources.visible;
                    }
                    else if (cell.ColumnIndex == 4)
                    {
                        cell.Value = canvasView1.Canvas.Layers[canvasView1.Canvas.Layers[cell.RowIndex]].Locked ? Properties.Resources.unlocked : Properties.Resources.locked;
                    }
                }
            }

            foreach (DataGridViewRow row in layerManager.Rows)
            {
                row.Selected = false;
            }
            layerManager.Rows[canvasView1.Canvas.Layers.IndexOf(canvasView1.Canvas.SelectedLayer)].Selected = true;

            layerManager.Invalidate();
            canvasView1.Canvas.Invalidate();
        }
        #endregion

        #region Loading And Saving
        private void MainForm_Load(object sender, EventArgs e)
        {
            welcomeForm.ShowDialog();
            if (welcomeForm.myDialogResult == MyDialogResult.Cancel)
            {
                Application.Exit();
            }
            else if (welcomeForm.myDialogResult == MyDialogResult.OK)
            {
                var v = canvasView1.Canvas;

                v.Width = welcomeForm.CanvasWidth;
                v.Height = welcomeForm.CanvasHeight;
                v.BackColor = welcomeForm.CanvasColor;
            }
            else if (welcomeForm.myDialogResult == MyDialogResult.Load)
            {
                LoadFile(true);
            }
            else if (welcomeForm.myDialogResult == MyDialogResult.Resume)
            {
                using (var fs = new FileStream("CourseProject.Resources.data.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    var v = canvasView1.Canvas;

                    v.Width = welcomeForm.CanvasWidth;
                    v.Height = welcomeForm.CanvasHeight;
                    v.BackColor = welcomeForm.CanvasColor;

                    var bf = new BinaryFormatter();
                    canvasView1.Canvas.Layers = (LayerCollection)bf.Deserialize(fs);
                    canvasView1.Canvas.SelectedLayer = canvasView1.Canvas.Layers.Internal.FirstOrDefault(x => x.Key.Order == 0).Value;
                    UpdateLayerManager();
                }
            }

            canvasView1.Canvas.SetPropertyGrid(propertyGrid1);
            propertyGrid1.SelectedObject = canvasView1.Canvas;

            UpdateLayerManager();
        }
        private void LoadFile(bool welcomeLoad = false)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"C:\";
                openFileDialog.Filter = "Binary Serialization (*.bin)|*.bin|JPG|*.jpg|BMP|*.bmp|PNG|*.png";
                openFileDialog.Title = "Open File";
                openFileDialog.ShowDialog();

                if (openFileDialog.FileName != "")
                {
                    _saveTarget = openFileDialog.FileName;
                    this.Text = this.Text + " - " + _saveTarget;

                    using (FileStream fs = (FileStream)openFileDialog.OpenFile())
                    {
                        switch (openFileDialog.FilterIndex)
                        {
                            case 1:
                                var m = canvasView1.Canvas;

                                m.Width = 500;
                                m.Height = 500;
                                m.BackColor = welcomeForm.CanvasColor;

                                var binaryFormatter = new BinaryFormatter();
                                canvasView1.Canvas.Layers = (LayerCollection) binaryFormatter.Deserialize(fs);
                                canvasView1.Canvas.SelectedLayer = canvasView1.Canvas.Layers.Internal.FirstOrDefault(x => x.Key.Order == 0).Value;
                                UpdateLayerManager();
                                break;

                            case 2:
                            case 3:
                            case 4:
                            case 5:
                                var img = Image.FromFile(openFileDialog.FileName);
                                if (welcomeLoad)
                                {
                                    canvasView1.Canvas.Width = img.Width;
                                    canvasView1.Canvas.Height = img.Height;
                                }
                                canvasView1.Canvas.Add(new Picture(img));
                                canvasView1.Canvas.Invalidate();
                                break;
                        }
                    }
                    canvasView1.Canvas.Invalidate();
                }
            }
        }
        private void SaveFile(bool saveAs = false)
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                if (saveAs || _saveTarget == null || _saveTarget == "")
                {
                    saveFileDialog.Filter = "Binary Serialization (*.bin)|*.bin|JPeg Image|*.jpg|Bitmap Image|*.bmp|PNG|*.png";
                    saveFileDialog.Title = "Save File";
                    saveFileDialog.ShowDialog();

                    _saveTarget = saveFileDialog.FileName;
                }

                if (_saveTarget == null || _saveTarget == "")
                    return;


                using (FileStream fs = new FileStream(_saveTarget, FileMode.Create, FileAccess.Write))
                {
                    switch (saveFileDialog.FilterIndex)
                    {
                        case 1:
                            var binaryFormatter = new BinaryFormatter();
                            binaryFormatter.Serialize(fs, canvasView1.Canvas.Layers);
                            break;

                        case 2:
                            canvasView1.Canvas.CurrentStateToImage()
                                .Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                            break;

                        case 3:
                            canvasView1.Canvas.CurrentStateToImage()
                                .Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                            break;

                        case 4:
                            canvasView1.Canvas.CurrentStateToImage().Save(fs, System.Drawing.Imaging.ImageFormat.Png);
                            break;
                    }
                }

            }
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_saveTarget != "" && _saveTarget != null)
            {
                using (UnsavedDialog dg = new UnsavedDialog())
                {
                    dg.ShowDialog();
                    if (dg.DialogResult == DialogResult.OK)
                    {
                        SaveFile();
                    }
                    else if (dg.DialogResult == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }
                    else if (dg.DialogResult == DialogResult.No)
                    {
                        dg.Close();
                    }
                }
            }

            using (var fs = new FileStream("CourseProject.Resources.data.bin", FileMode.Create, FileAccess.Write))
            {
                var bf = new BinaryFormatter();
                bf.Serialize(fs, canvasView1.Canvas.Layers);
            }
        }
        #endregion Loading And Saving

        private void MainForm_OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                var query = canvasView1.Canvas.SelectedLayer.Where(x => x.Selected).ToList();
                foreach (var target in query)
                {
                    canvasView1.Canvas.SelectedLayer.Remove(target);
                    canvasView1.Canvas.Refresh();
                }

                e.Handled = true;
            }

            if (Control.ModifierKeys == Keys.Control)
            {
                if (e.KeyCode == Keys.A)
                {
                    foreach (var v in canvasView1.Canvas.SelectedLayer)
                        v.Selected = true;

                    canvasView1.Canvas.Invalidate();

                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.C)
                {
                    var selected = canvasView1.Canvas.SelectedLayer.Where(x => x.Selected)
                        .Select(x => x.Copy());

                    if (selected != null)
                    {
                        _copyTargetCount = selected.Count();
                        Clipboard.AddRange(selected);
                    }

                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.X)
                {
                    var selected = canvasView1.Canvas.SelectedLayer.Where(x => x.Selected).ToList();
                    var query = selected.Select(x => x.Copy()).ToList();

                    if (query != null)
                    {
                        _copyTargetCount = query.Count();
                        Clipboard.AddRange(query);
                    }

                    for (int i = 0; i < _copyTargetCount; i++)
                    {
                        canvasView1.Canvas.Remove(selected[i]);
                    }
                    canvasView1.Canvas.Invalidate();

                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.V)
                {
                    canvasView1.Canvas.DeselectAll();
                    for (int j = 0, i = Clipboard.Count - 1; j < _copyTargetCount; j++, i--)
                    {
                        canvasView1.Canvas.Add(Clipboard[i]);
                    }
                    canvasView1.Canvas.Invalidate();

                    e.Handled = true;
                }
            }
        }

        private void propertyGrid1_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            propertyGrid1.Invalidate();
            canvasView1.Canvas.Invalidate();
        }

        private void updownFillOpacity_ValueChanged(object sender, EventArgs e)
        {
            canvasView1.Canvas.FillOpacity = (int)updownFillOpacity.Value;
        }
    }
}
