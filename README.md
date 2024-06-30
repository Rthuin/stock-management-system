Stock Management Project

Stock Management Project is a web application developed using ASP.NET Core, Entity Framework Core, and MSSQL Server to manage stock operations.

About the Project
This project is designed as a web application allowing users to manage stocks. Users can add, view, edit, and delete stocks. Additionally, admin users have additional features for managing stocks.

Installation

    Install Dependencies: In the main directory of the project, right-click on the solution in Visual Studio and select "Manage NuGet Packages...". Ensure all necessary packages are installed.

    Database Connection: Update the ConnectionStrings section in appsettings.json with your own database server information:

    

  "ConnectionStrings": {
      "Default": "Server=YOUR_SERVER_NAME;Database=DbStockManagement;Trusted_Connection=True;TrustServerCertificate=true"
  }

Using Migrations: Open the Package Manager Console in Visual Studio (View > Other Windows > Package Manager Console). Run the following commands to create the database using migrations:



    Add-Migration InitialCreate
    Update-Database

    You can replace InitialCreate with any desired migration name.

    Running the Application: Open the project in Visual Studio and press F5 to start the application.

    The application will run by default at https://localhost:5001.

    Viewing in Browser: Navigate to https://localhost:5001 in your web browser to view the application.

License

This project is licensed under the MIT License. For detailed information, see the LICENSE file.




Stock Management Projesi

Stock Management Projesi, stok yönetimi işlemlerini gerçekleştirmek için ASP.NET Core, Entity Framework Core ve MSSQL Server kullanılarak geliştirilmiş bir uygulamadır.

Proje Hakkında
Bu proje, bir web uygulaması olarak tasarlanmış olup kullanıcıların stokları yönetmesine olanak tanır. Kullanıcılar stok ekleyebilir, stokları görebilir, düzenleyebilir ve silebilirler. Ayrıca, yönetici kullanıcılar stokları yönetmek için ek özelliklere sahiptir.



1. Bağımlılıkların Yüklenmesi: Projenin ana dizininde Visual Studio'da Solution Explorer üzerinden sağ tıklayarak "Manage NuGet Packages..." seçeneğini seçin. Burada gerekli tüm paketlerin yüklü olduğundan emin olun.

2. Veritabanı Bağlantısı: appsettings.json dosyasında bulunan ConnectionStrings bölümünü kendi veritabanı sunucu bilgilerinize göre güncelleyin:

   "ConnectionStrings": {
    "Default": "Server=YOUR_SERVER_NAME;Database=DbStockManagement;Trusted_Connection=True;TrustServerCertificate=true"
}


3. Migration Kullanımı: Visual Studio'da Package Manager Console'u açın (Tools > NuGet Package Manager > Package Manager Console). Aşağıdaki komutları sırasıyla çalıştırarak migrations özelliğini kullanarak veritabanınızı oluşturun:

sql

    Add-Migration InitialCreate
    Update-Database

    InitialCreate migration adı isteğe bağlı olarak değiştirilebilir.

    Uygulamayı Başlatma: Projeyi Visual Studio'da açın ve F5 tuşuna basarak uygulamayı başlatın.

    Uygulama varsayılan olarak https://localhost:5001 adresinde çalışacaktır.

    Tarayıcıda Görüntüleme: Tarayıcınızda https://localhost:5001 adresine giderek uygulamayı görüntüleyebilirsiniz.

Lisans

Bu proje MIT lisansı altında lisanslanmıştır. Detaylı bilgi için LICENSE dosyasına başvurabilirsiniz.



