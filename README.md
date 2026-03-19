# 💰 BudgetManager

> C# WinForms로 개발한 개인 가계부 애플리케이션입니다.  
> CRUD, 외부 API 연동, 파일 처리(CSV/Excel) 기능을 포함합니다.

![.NET](https://img.shields.io/badge/.NET-10.0-512BD4?style=flat-square&logo=dotnet)
![C#](https://img.shields.io/badge/C%23-WinForms-239120?style=flat-square&logo=csharp)
![SQLite](https://img.shields.io/badge/SQLite-003B57?style=flat-square&logo=sqlite)
![License](https://img.shields.io/badge/License-MIT-yellow?style=flat-square)

---

## 📸 스크린샷

> _(개발 완료 후 스크린샷 추가 예정)_

<!-- | 메인 화면 | 거래 내역 | 통계 |
|-----------|-----------|------|
| ![main]() | ![transaction]() | ![statistics]() | -->

---

## 📋 프로젝트 개요

개인 수입/지출을 효율적으로 관리하기 위한 데스크톱 가계부 앱입니다.

**개발 목적**
- C# WinForms 실무 역량 시연
- MVC 패턴 기반 계층 분리 설계
- DB 연동, 외부 API, 파일 I/O 등 핵심 기능 통합 구현

---

## ✨ 주요 기능

| 기능 | 설명 |
|------|------|
| 📊 **대시보드** | 현재 잔고, 이번 달 수입/지출 요약 |
| 📝 **거래 내역 관리** | 수입/지출 추가, 수정, 삭제, 검색 (CRUD) |
| 📈 **통계** | 월별/카테고리별 차트 시각화 |
| 💱 **환율 변환** | 실시간 환율 API로 외화 지출 원화 환산 |
| 📁 **파일 처리** | CSV/Excel 내보내기 및 가져오기 |

---

## 🛠️ 기술 스택

| 구분 | 기술 |
|------|------|
| **언어** | C# (.NET 10.0) |
| **UI** | Windows Forms (WinForms) |
| **DB** | SQLite (Microsoft.Data.Sqlite) |
| **차트** | LiveCharts2 |
| **API** | ExchangeRate-API (환율) |
| **파일** | CsvHelper, ClosedXML |
| **테스트** | xUnit |

---

## 🏗️ 아키텍처 구조

<!-- MVC 패턴을 기반으로 역할에 따라 계층을 분리했습니다.

```
BudgetManager/
├── Forms/                  # View — UI 화면
│   ├── MainForm.cs         # 메인 대시보드
│   ├── TransactionForm.cs  # 거래 내역 CRUD
│   ├── StatisticsForm.cs   # 통계 차트
│   ├── ExchangeRateForm.cs # 환율 변환
│   └── ImportExportForm.cs # 파일 가져오기/내보내기
│
├── Models/                 # Model — 데이터 구조
│   ├── Transaction.cs      # 거래 내역
│   └── Category.cs         # 카테고리
│
├── Services/               # Controller — 비즈니스 로직
│   ├── DatabaseService.cs  # SQLite CRUD
│   ├── ExchangeRateService.cs # 환율 API 호출
│   └── FileService.cs      # CSV/Excel 처리
│
└── Helpers/
    └── ValidationHelper.cs # 입력 유효성 검사
```

### 계층 간 의존 관계

```
Forms (View)
   └── Services (Controller)
         └── Models (Model)
         └── DatabaseService → SQLite
         └── ExchangeRateService → 외부 API
         └── FileService → 파일 시스템
```

--- -->

## 🚀 설치 및 실행

### 요구사항
- Windows 10 이상
- .NET 8.0 Runtime

### 실행 방법

```bash
# 1. 레포 클론
git clone https://github.com/your-username/BudgetManager.git

# 2. 프로젝트 폴더 이동
cd BudgetManager

# 3. 빌드
dotnet build

# 4. 실행
dotnet run --project BudgetManager
```

### NuGet 패키지 복원
Visual Studio에서 열면 자동으로 복원됩니다.  
CLI 사용 시:
```bash
dotnet restore
```

---

## 🔑 환경 설정

<!-- 환율 API 키가 필요합니다. [ExchangeRate-API](https://www.exchangerate-api.com/)에서 무료로 발급 가능합니다.

`appsettings.json` 파일을 생성하고 아래 내용을 입력하세요:

```json
{
  "ExchangeRateApiKey": "YOUR_API_KEY_HERE"
}
```

> ⚠️ `appsettings.json`은 `.gitignore`에 포함되어 있습니다. API 키를 절대 커밋하지 마세요. -->

---

## 📅 개발 일정

| 단계 | 내용 | 상태 |
|------|------|------|
| 1단계 | 프로젝트 구조 설계 + README | ✅ 완료 |
| 2단계 | DB 모델 & DatabaseService | ✅ 완료 |
| 3단계 | 메인 화면 (잔고 요약) | ✅ 완료 |
| 4단계 | 수입/지출 CRUD 화면 | ⏳ 예정 |
| 5단계 | 통계 화면 (차트) | ⏳ 예정 |
| 6단계 | 환율 API 연동 | ⏳ 예정 |
| 7단계 | CSV/Excel 파일 처리 | ⏳ 예정 |
| 8단계 | README 완성 + 스크린샷 | ⏳ 예정 |
<!-- 🔄 진행중 -->
---

## 📄 라이선스

MIT License — 자유롭게 사용, 수정, 배포 가능합니다.