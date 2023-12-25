public class Scheduler
{
    readonly int second = 1;
    readonly String name;

    public Scheduler()
    {
        this.name = "일정관리"; // 읽기 전용 필드는 생성자에서도 대입 가능
    }

    public void Run()
    {
        this.second = 5; // 컴파일 오류 발생! 일반 메서드에서 값을 대입할 수 없다.
    }
}