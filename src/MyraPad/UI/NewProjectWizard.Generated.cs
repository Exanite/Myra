/* Generated by MyraPad at 11/13/2023 10:44:41 PM */
using Myra;
using Myra.Graphics2D;
using Myra.Graphics2D.TextureAtlases;
using Myra.Graphics2D.UI;
using Myra.Graphics2D.Brushes;
using Myra.Graphics2D.UI.Properties;
using FontStashSharp.RichText;
using AssetManagementBase;

#if STRIDE
using Stride.Core.Mathematics;
#elif PLATFORM_AGNOSTIC
using System.Drawing;
using System.Numerics;
using Color = FontStashSharp.FSColor;
#else
// MonoGame/FNA
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
#endif

namespace MyraPad.UI
{
	partial class NewProjectWizard: Dialog
	{
		private void BuildUI()
		{
			var label1 = new Label();
			label1.Text = "Grid";

			_radioButtonGrid = new RadioButton();
			_radioButtonGrid.Id = "_radioButtonGrid";
			_radioButtonGrid.Content = label1;

			var label2 = new Label();
			label2.Text = "HorizontalStackPanel";

			_radioButtonHorizontalStackPanel = new RadioButton();
			_radioButtonHorizontalStackPanel.Id = "_radioButtonHorizontalStackPanel";
			_radioButtonHorizontalStackPanel.Content = label2;

			var label3 = new Label();
			label3.Text = "VerticalStackPanel";

			_radioButtonVerticalStackPanel = new RadioButton();
			_radioButtonVerticalStackPanel.Id = "_radioButtonVerticalStackPanel";
			_radioButtonVerticalStackPanel.Content = label3;

			var label4 = new Label();
			label4.Text = "Panel";

			_radioButtonPanel = new RadioButton();
			_radioButtonPanel.Id = "_radioButtonPanel";
			_radioButtonPanel.Content = label4;

			var label5 = new Label();
			label5.Text = "ScrollViewer";

			_radioButtonScrollViewer = new RadioButton();
			_radioButtonScrollViewer.Id = "_radioButtonScrollViewer";
			_radioButtonScrollViewer.Content = label5;

			var label6 = new Label();
			label6.Text = "HorizontalSplitPane";

			_radioButtonHorizontalSplitPane = new RadioButton();
			_radioButtonHorizontalSplitPane.Id = "_radioButtonHorizontalSplitPane";
			_radioButtonHorizontalSplitPane.Content = label6;

			var label7 = new Label();
			label7.Text = "VerticalSplitPane";

			_radioButtonVerticalSplitPane = new RadioButton();
			_radioButtonVerticalSplitPane.Id = "_radioButtonVerticalSplitPane";
			_radioButtonVerticalSplitPane.Content = label7;

			var label8 = new Label();
			label8.Text = "Window";

			_radioButtonWindow = new RadioButton();
			_radioButtonWindow.Id = "_radioButtonWindow";
			_radioButtonWindow.Content = label8;

			var label9 = new Label();
			label9.Text = "Dialog";

			_radioButtonDialog = new RadioButton();
			_radioButtonDialog.Id = "_radioButtonDialog";
			_radioButtonDialog.Content = label9;

			var verticalStackPanel1 = new VerticalStackPanel();
			verticalStackPanel1.Widgets.Add(_radioButtonGrid);
			verticalStackPanel1.Widgets.Add(_radioButtonHorizontalStackPanel);
			verticalStackPanel1.Widgets.Add(_radioButtonVerticalStackPanel);
			verticalStackPanel1.Widgets.Add(_radioButtonPanel);
			verticalStackPanel1.Widgets.Add(_radioButtonScrollViewer);
			verticalStackPanel1.Widgets.Add(_radioButtonHorizontalSplitPane);
			verticalStackPanel1.Widgets.Add(_radioButtonVerticalSplitPane);
			verticalStackPanel1.Widgets.Add(_radioButtonWindow);
			verticalStackPanel1.Widgets.Add(_radioButtonDialog);

			
			Title = "Choose Root Container";
			Left = 425;
			Top = 74;
			Content = verticalStackPanel1;
		}

		
		public RadioButton _radioButtonGrid;
		public RadioButton _radioButtonHorizontalStackPanel;
		public RadioButton _radioButtonVerticalStackPanel;
		public RadioButton _radioButtonPanel;
		public RadioButton _radioButtonScrollViewer;
		public RadioButton _radioButtonHorizontalSplitPane;
		public RadioButton _radioButtonVerticalSplitPane;
		public RadioButton _radioButtonWindow;
		public RadioButton _radioButtonDialog;
	}
}
