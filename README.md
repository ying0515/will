# will
will homework

第一周作業：

* 請使用 "客戶資料" 這個資料庫做開發 (如附件檔案)
* 請實作出「客戶資料管理」、「客戶聯絡人管理」與「客戶銀行帳戶管理」等簡易 CRUD 功能 (盡量做各種功能出來)
* 實作一份簡易報表，顯示欄位有「客戶名稱、聯絡人數量、銀行帳戶數量」共三個欄位，用一個表格呈現報表即可。
* 該專案要在資料庫中建立一個檢視表，並且匯入 EDMX 檔。
* 主選單要有連結可以直接連到三個主要功能的列表頁。
* 對於 Create 與 Edit 表單要套用欄位驗證 (必填、Email格式、欄位長度限制等驗證)
* 刪除資料功能不能真的刪除資料庫中的資料，必須修改資料庫，加上一個「是否已刪除」欄位，資料庫中的該欄位為 bit 類型，
  0 代表未刪除，1 代表已刪除，且列表頁不得顯示已刪除的資料。
* 實作「客戶聯絡人」時，同一個客戶下的聯絡人，其 Email 不能重複。
* 新增或更新客戶資料時，需驗證「手機」的電話格式必須為 "\d{4}-\d{6}" 的格式 ( e.g. 0911-111111 )

