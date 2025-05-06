# Triển khai .NET Microservices với Kubernetes, AKS, ACR và Azure DevOps

## 🌐 Tổng quan

Dự án này hướng dẫn cách phát triển và triển khai các **.NET Microservices** lên **Azure Kubernetes Services (AKS)**, sử dụng **Azure Container Registry (ACR)** và tự động hóa quy trình triển khai bằng **Azure DevOps** và **GitHub Actions**.

Sơ đồ kiến trúc: https://github.com/TanPham2808/Devops-Microservices/blob/main/So%20do%20kien%20truc.png


Chúng ta sẽ xây dựng và triển khai **3 microservices**:

### 🛒 1. Shopping MVC Client Application
- Ứng dụng web ASP.NET MVC: `Shopping.Client`.
- Ban đầu chạy độc lập với dữ liệu nội bộ.
- Thêm hỗ trợ Docker với Dockerfile.
- Đẩy Docker image lên Docker Hub.
- Triển khai lên **Azure Web App for Containers** để thử nghiệm.

### 🧾 2. Shopping API Microservice
- Microservice `Shopping.API` kết nối với MongoDB.
- Cung cấp các API thực hiện CRUD cho dữ liệu sản phẩm.
- Container hóa bằng Dockerfile.
- Đẩy image lên **Azure Container Registry (ACR)**.

### 🗄 3. MongoDB Microservice
- Sử dụng MongoDB NoSQL để lưu trữ dữ liệu sản phẩm.
- Dùng MongoDB Docker image từ Docker Hub.
- Kết nối MongoDB với `Shopping.API`.

---

## 🧪 Quy trình triển khai

1. Tạo Docker images cho từng dịch vụ.
2. Dùng **Docker Compose** để khởi tạo và test toàn bộ hệ thống cục bộ.
3. Triển khai lên **local Kubernetes cluster**.
4. Push Docker images lên **Azure Container Registry (ACR)**.
5. Triển khai hệ thống lên **Azure Kubernetes Services (AKS)**.
6. Cập nhật microservices với **zero-downtime deployments**.

---

## 🔁 Tự động hóa CI/CD với Azure DevOps

- Tạo **Azure Pipelines** riêng biệt cho từng microservice bằng YAML.
- Khi push code lên GitHub:
  - Pipeline tự động build Docker image.
  - Push image lên **ACR**.
  - Triển khai lên **AKS** với downtime bằng 0.

---

## 🔗 Tài liệu và khóa học

🎓 [Khóa học Udemy có giảm giá – Từng bước phát triển và triển khai repo này](https://www.udemy.com/course/deploying-net-microservices-with-k8s-aks-and-azure-devops/?couponCode=APRI25)

✍️ [Bài viết trên Medium – Triển khai .NET Microservices lên AKS và tự động hóa với Azure DevOps](https://mehmetozkaya.medium.com/deploying-net-microservices-to-azure-kubernetes-services-aks-and-automating-with-azure-devops-c50bdd51b702)
