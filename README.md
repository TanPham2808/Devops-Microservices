Triển khai .NET Microservices lên Kubernetes và chuyển sang Azure Kubernetes Services (AKS), sử dụng Azure Container Registry (ACR) và tự động hóa triển khai với Azure DevOps và GitHub

Tổng quan
Chúng ta sẽ phát triển và triển khai 3 microservices cùng nhau:

Shopping MVC Client Application

Phát triển ứng dụng web ASP.NET MVC tên là Shopping.Client để tiêu thụ các API từ backend.

Ban đầu xây dựng như một ứng dụng độc lập chứa dữ liệu riêng.

Thêm hỗ trợ Docker bằng Dockerfile, đẩy Docker image lên Docker Hub.

Thử nghiệm triển khai lên Azure Web App for Container.

Shopping API Application

Phát triển microservice Shopping.API sử dụng MongoDB.

Thực hiện CRUD trên dữ liệu sản phẩm và cung cấp API cho Shopping.Client.

Container hóa ứng dụng API bằng Dockerfile và đẩy image lên Azure Container Registry (ACR).

MongoDB Microservice

Dữ liệu sản phẩm được lưu trữ trong MongoDB (NoSQL).

Sử dụng MongoDB Docker image từ Docker Hub và kết nối với Shopping.API.

Sau bước này, ta có 3 microservices:

Shopping.Client

Shopping.API

MongoDB

Các bước thực hiện:

Tạo Docker images

Sử dụng Docker Compose để kết hợp các containers và kiểm thử

Triển khai containers trên Kubernetes cục bộ

Đẩy images lên ACR

Chuyển triển khai lên Azure Kubernetes Services (AKS)

Cập nhật microservices với zero-downtime deployments

Tự động hóa triển khai với Azure DevOps và GitHub (CI/CD)

Tạo các CI/CD pipelines sử dụng Azure Pipelines

Khi code được đẩy lên GitHub, pipeline được kích hoạt:

Build Docker images

Push lên ACR

Triển khai lên AKS với zero-downtime
