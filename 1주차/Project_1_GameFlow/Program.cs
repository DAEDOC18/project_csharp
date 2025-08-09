namespace Project_1_GameFlow
{
    internal class Program
    {
        public void Method()
        {

        }


        static void Main(string[] args)
        {
            #region 프로그래밍 언어의 기본 문법 - 변수

            #region 프로그래밍 기본 문법 - 메소드(함수)

            // 기본 형태
            // 접근지정자 리턴타입 함수이름 (타입 변수이름)
            // public void methodname(int num)

            //c#에서의 특징
            // 1. 메소드는 클래스 안에서 정의 되어야 한다.
            // 2. 메소드의 선언과 사용 방식이 다르다.
            // 2-1. 선언은 구현되지 않은 내용을 직접 정의 하는 것이다. 범위로 표현을 해준다.
            // 함수 선언 이후 중괄호로 내용을 표시한다.
            // 2-2 정의된 함수를 사용하기 위해서는 함수의 이름과 소괄호로 함께 호출한다.

            // 함수를 만들어 줘, 접근 지정자를 public,반환 타입을 void로, 함수 이름을 showtitle 만들어줘, 매개 인자를 누락

            // 콘솔 환경, 언어는 C#, 특정 문자열의 색상을 다른 색상으로 변경 해 주는 함수를 만들어 줘.
            // 접근지정자는 public, 반환값은 너가 정해 줘, 함수의 이름 settextcolor로, 매개 변수를 색상의 이름으로 받을 수 있도록 타입을 string, 변수이름 color로 만들어줘


            #endregion

            // 변수 : 특정 타입의 데이터를 메모리에 저장해서 다시 사용하는 데이터. 
            // 정수, 실수(부동소수점), 문자
            // 타입뒤에 변수를 구분하기 위한 이름을 지어 준다.

            // 내가 정수를 사용하고 싶다. int 
            // 내가 실수를 사용하고 싶다. float
            // 내가 문자열을 사용하고 싶다. string
            // 내가 문자를 사용하고 싶다. char

            // 정수의 이름 : playerHP
            // 실수의 이름 : 시간을 초단위로 표현 Time
            // 문자열의 이름 : title
            // 문자의 이름 : myChar



            // 변수의 선언 및 초기화

            // (1) AI가 만들어준 데이터를 다은 데이터로 바꿔 보세요
            // (2) AI 질문을 할때 변수의이름과 타입을 지정해서 질문 하세요.


            int num1 = 10;
            float numfloat1 = 1.1f;
            string myString = "안녕!";
            char myChar = 'a';

            int playerHP = 50;
            float time = 30.5f;
            string title = "테트리스";
            char mychar = 'b';



            #endregion

            #region 게임 개발 영역
            // 주석 : 컴퓨터가 읽지 못하는 영역 입니다.
            // 내용을 정리하거나, 코드를 읽는 다른 사람을 배려해서 작성하는 영역 입니다.

            // 단축키 : ctrl + k + c 범위 주석 활성화
            // 단축키 : ctrl + k + u 범위 주석 비활성화
            // 단축키 : shift + alt + 방향키 위, 아래

            #region 타이틀
            // 1.타이틀
            // "C# 작성을 할 것이다. 콘솔 환경에서 타이틀을 만들어 줘.
            // 콘솔 창의 타이틀을 설정 합니다.
            // 타이틀은 게임 화면에 이미지와 게임 시작 버튼으로 이루어 짐

            Console.Clear();
            DrawTitleScreen();
            WaitForStart();
            #endregion

            #region 캐릭터
            // 2.캐릭터
            // 캐릭터는 체력, 공격력이 존재한다.UI
            // 게임 캐릭터의 체력과 공격력을 설정 한 후, 콘솔환경에서 UI로 화면에 떠오르게 만들어줘
            // 1. 캐릭터 정보 설정 (클래스 없이 변수 사용)
            string characterName = "검사";
            int maxHealth = 500;
            int currentHealth = 300;
            int attackPower = 100;

            // 2. 초기 UI 화면 그리기
            DrawUI(characterName, maxHealth, currentHealth, attackPower);


            Console.ReadKey();
            #endregion

            #region 전투
            // 3.전투 
            #endregion

            #region 보상
            // 4.보상 
            #endregion

            #region 성장
            // 5.성장 
            #endregion

            #region 스토리
            // 6.스토리 
            #endregion
            #endregion


        }

        static void DrawUI(string name, int maxHp, int currentHp, int attack)
        {
            Console.Clear();
            Console.WriteLine("=======================");
            Console.WriteLine($"  캐릭터: {name}");
            Console.WriteLine("=======================");

            // 체력바 그리기
            Console.Write("  체력: ");
            Console.ForegroundColor = ConsoleColor.Green;
            int healthBarLength = (int)((double)currentHp / maxHp * 20);
            Console.Write(new string('■', healthBarLength));
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(new string('□', 20 - healthBarLength));
            Console.ResetColor();
            Console.WriteLine($"  {currentHp}/{maxHp}");

            // 공격력 표시
            Console.WriteLine("-----------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"  공격력: {attack}");
            Console.ResetColor();
            Console.WriteLine("=======================");
        }

        static void DrawTitleScreen()
        {
            // 타이틀 (ASCII 아트)
            string title = @"
                       _     _
                      | |   | |
                      | |__ | | __ _ _   _
                      | '_ \| |/ _` | | | |
                      | |_) | | (_| | |_| |
                      |_.__/|_|\__,_|\__, |
                                      __/ |
                                     |___/
";
            Console.ForegroundColor = ConsoleColor.White; // 타이틀 색상 변경
            Console.WriteLine(title);

            Console.WriteLine("\n\n");

            // 시작 버튼 영역
            Console.ForegroundColor = ConsoleColor.Yellow; // 버튼 색상 변경
            string startButton = @"
                    =========================
                      |  아무키나 누르세용 |
                    =========================
";
            Console.WriteLine(startButton);
            Console.ResetColor(); // 색상 초기화
        }

        static void WaitForStart()
        {
            Console.CursorVisible = false; // 커서 숨기기
            Console.SetCursorPosition(28, 14); // "Press Enter" 텍스트 근처로 커서 이동
            Console.Write("▶");

            while (Console.ReadKey(true).Key != ConsoleKey.Enter)
            {
                // Enter 키를 누를 때까지 반복
                Thread.Sleep(100);
            }

            Console.Clear();
            Console.WriteLine("게임이 시작되었습니다!");
            Console.CursorVisible = true; // 게임 시작 후 커서 다시 보이게 설정
        }
    }
}



            
        

