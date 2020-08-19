 
//how to reset auto increment index
ALTER TABLE employee AUTO_INCREMENT=1

//auto code generation for mvc 
dotnet aspnet-codegenerator controller -name StudentController -actions -m Student -dc MISDbContext -outDir Controllers -f
dotnet aspnet-codegenerator controller -name ProductGroupController -actions -m ProductGroup -dc MISDbContext -outDir Controllers -f
dotnet aspnet-codegenerator controller -name ProductController -actions -m Product -dc MISDbContext -outDir Controllers -f
dotnet aspnet-codegenerator controller -name ProductOrderController -actions -m ProductOrder -dc MISDbContext -outDir Controllers -f
dotnet aspnet-codegenerator controller -name OrderStatusController -actions -m OrderStatus -dc MISDbContext -outDir Controllers -f
dotnet aspnet-codegenerator controller -name xController -actions -m x -dc MISDbContext -outDir Controllers -f
   


//github 
//goto your project folder
git init
git add --all
git commit -m "first commit"
git remote add origin https://github.com/mentalwisdom/mis.git
git push -u origin master
                
//push an existing repository from the command line
//goto your project folder
git push -u origin master   