# LoginScreen
개요-C# 프로그래밍학습
-1줄소개 -사용한플랫폼: -C#, .NET Windows Forms, Visual Studio, GitHub

-사용한컨트롤 : label, textbox, button 
사용한기술과구현한기능:로그인 창에 아이디와 비밀번호 입력시 로그인 실패시 로그인 실패 메시지 출력

실행화면(과제1)
-과제1코드의실행스크린샷![과제1 실행화면] (img/lo2.png)  <img width="399" height="473" alt="lo1" src="https://github.com/user-attachments/assets/6e0affc5-dbe6-4c0d-bfc4-b07f29be1c5d" />
<img width="395" height="474" alt="lo2" src="https://github.com/user-attachments/assets/acc06d97-5a11-4a17-8866-6a88adc7a140" />
<img width="394" height="472" alt="lo3" src="https://github.com/user-attachments/assets/4ea3d783-4e32-4769-bdcb-a2cb597e01a2" />
<img width="398" height="473" alt="lo4" src="https://github.com/user-attachments/assets/09925365-90ab-4f91-bc7b-9cccf3e732a7" />
<img width="397" height="473" alt="lo5" src="https://github.com/user-attachments/assets/e49be9f8-dc88-46c8-95c6-e99631728e9e" />
<img width="396" height="471" alt="lo6" src="https://github.com/user-attachments/assets/c3b93a4d-df28-49ce-9052-bfb3a79a8b85" />


-과제내용
그인 화면의 전체적인 레이아웃을 설계하고 기본적인 인증 기능을 구축합니다. 
-구현내용과기능설명
UI 레이아웃 설계: 아이디 입력창(txtID), 비밀번호 입력창(txtPW), 로그인 버튼(btnLogin)을 배치하여 표준적인 로그인 폼 구성.

정적 계정 인증: 코드 내에 지정된 아이디(sungmin)와 비밀번호(superman)를 기준으로 입력값의 일치 여부를 판별.

로그인 판별 로직: 조건문(if-else)을 활용하여 성공과 실패에 따른 분기 처리 프로세스 구현.
실행화면(과제2)
-과제2코드의실행스크린샷 ![과제2 실행화면] 
<img width="394" height="473" alt="201" src="https://github.com/user-attachments/assets/693b880e-4533-43e3-b7bb-105d60cca025" />
<img width="396" height="468" alt="203" src="https://github.com/user-attachments/assets/1466a3ca-fc53-41df-bddd-96db6a7e566d" />
<img width="396" height="473" alt="204" src="https://github.com/user-attachments/assets/7be17629-c079-4eed-b5c8-60893797645e" />

-과제내용
사용자 편의성을 높이기 위해 힌트 텍스트(Placeholder) 기능을 추가하고, 직관적인 에러 피드백 시스템을 구축합니다.
-구현내용과기능설명
Placeholder 기능: 텍스트박스 클릭 시 안내 문구(예: "아이디를 입력하세요")가 사라지고, 입력을 하지 않고 벗어날 경우 다시 나타나는 동적 힌트 기능 구현.

Label 기반 에러 메시지: 기존의 번거로운 MessageBox 팝업 대신, 입력창 하단에 Label 컨트롤을 배치하여 실시간으로 에러 메시지 출력.

상태 제어 로직: Visible 속성을 활용하여 평상시에는 메시지를 숨기고, 로그인 실패 시에만 빨간색 글씨로 경고 문구가 나타나도록 제어.
