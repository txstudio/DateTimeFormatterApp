# DateTime 日期與字串轉換的範例應用程式

此應用程式使用 .NET Core 2.0 進行開發

若要執行此應用程式前請確認環境符合 .NET Core 2.0 執行環境。

### 簡短說明

此程式碼主要範例為將日期 (DateTime) 輸出成英文月份文字 (String)

> 2018/01/18 => JUN/18/2018

將英文月份日期文字 (String) 的格式轉換成日期型態 (DateTime)

> JUN/18/2018 => 2018/01/18

### 主控台應用程式輸出內容

```
"2018-03-22T13:47:33.2506564+08:00"
Parse DateTime to string

format  yyyy/MM/dd HH:mm:ss
out     2018/03/22 13:47:33

format  yyyy/MM/dd
out     2018/03/22

format  yyyy-MM-dd
out     2018-03-22

format  MMM/dd/yyyy
out     Mar/22/2018

Parse string to DateTime

input   2018/03/22 13:47:33
out     "2018-03-22T13:47:33"

input   2018/03/22
out     "2018-03-22T00:00:00"

input   2018-03-22
out     "2018-03-22T00:00:00"

input   Mar/22/2018
out     "2018-03-22T00:00:00"
```
