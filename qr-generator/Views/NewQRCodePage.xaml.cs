using System.Diagnostics;

namespace qr_generator.Views;

public partial class NewQRCodePage : ContentPage
{
	public NewQRCodePage()
	{
		InitializeComponent();

		Models.QRCode qr = new Models.QRCode();
		qr.File_Path = FileSystem.AppDataDirectory;
		qr.File_Name = "qr-code.png";
		qr.Version = "1";
		qr.Border = "1";
		qr.Box_Size = "20";
		qr.Back_Color = "white";
		qr.Fill_Color = "black";
		qr.Data = "www.google.com";

		BindingContext = qr;
	}
	private void run_Clicked(object sender, EventArgs e)
	{
		string qrgen_exe = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"qr-gen.exe");

		ProcessStartInfo startInfo = new ProcessStartInfo(qrgen_exe);
		startInfo.UseShellExecute = false;
		startInfo.CreateNoWindow = true;



		if (BindingContext is Models.QRCode qr)
		{
			string newFile = Path.Combine(qr.File_Path, qr.File_Name);
			startInfo.Arguments = $"{qr.Data} {newFile} {qr.Version} {qr.Box_Size} {qr.Border} {qr.Fill_Color} {qr.Back_Color}";
			Process process = Process.Start(startInfo);
			process.WaitForExit();
			Image image = new Image { Source = newFile };
			qr.Image_Path = image.Source;

			ImagePreview.Source = qr.Image_Path;
		}
	}

	private void OpenOutput_Clicked(object sender, EventArgs e)
	{
		if (BindingContext is Models.QRCode qr)
			Process.Start("explorer.exe", $@"{FileSystem.AppDataDirectory}");

	}

	private void ViewCode_Clicked(object sender, EventArgs e)
	{
		if (BindingContext is Models.QRCode qr)
		{
			Process.Start("explorer.exe", $@"{Path.Combine(FileSystem.AppDataDirectory, qr.File_Name)}");
		}
	}

}