# PrintSendTester 
<!--![배지 또는 로고 이미지 (선택사항)](링크)-->
<!--프로젝트에 대한 간단한 설명을 여기에 작성합니다.-->
(바코드)프린터로 RawData를 전송할 수있는 테스트 프로그램 입니다.

![KioskLite](https://file.notion.so/f/f/68c582fe-3f8d-458e-8ac9-83199eed61e0/0333b6a6-1fe3-4c73-8f08-672379f4adac/%ED%82%A4%EC%98%A4%EC%8A%A4%ED%81%AC.gif?table=block&id=4314e632-2350-4728-bc82-5f5d790e3024&spaceId=68c582fe-3f8d-458e-8ac9-83199eed61e0&expirationTimestamp=1731240000000&signature=8gEi9Qc4FCf3cPadP2RPH0gblfChpOMIceAgQmwqEE0)

## 목차
- [PrintSendTester](#printsendtester)
  - [목차](#목차)
  - [소개](#소개)
  - [사용법](#사용법)
<!--- [기여](#기여)
- [라이선스](#라이선스)
- [문의](#문의)
-->
## 소개
<!--프로젝트에 대한 자세한 설명을 여기에 작성합니다.  -->
- **개발환경** : C#, .Net Framework 4.8, Visual Studio 2019

- **주요기능** : 
   
   1. 프린터 드라이버로 Raw Data전송
   2. 프린터 드라이버로 파일 전송
   3. IP 소켓 통신으로 Raw Data전송
   4. 주기적으로 데이터를 전송할 수 있는 매크로 기능
   
## 사용법

1. 프린터 드라이버를 선택하거나, 프린터의 IP주소와 포트를 입력합니다.
2. 전송할 RawData를 입력합니다.
    * 바코드 프린터의 경우 각 프린터의 명령어를 작성하여 전달하면 출력 및 제어가 가능합니다.
        <details> 
        <summary>ZPL 예시</summary>

        ```
        ^XA
        ^SEE:UHANGUL.DAT^FS
        ^CW1,E:KFONT3.FNT^CI26^FS
        ^FO50,10^A1,40,40^FD테스트1^FS
        ^FO50,50^A1,40,40^FD테스트2^FS
        ^XZ
        ```

         </details>

3. 전송 버튼을 눌러 데이터를 전송합니다.

* 매크로 기능은 위와 동일하게 사용하되, 인터벌을 설정하고 시작버튼을 눌러 기능을 활성화 합니다.