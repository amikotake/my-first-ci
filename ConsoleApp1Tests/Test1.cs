namespace ConsoleApp1Tests;

[TestClass]
public class Test1
{
    [TestMethod]
    public void TestAdd30Days()
    {
        // 1. 基準となる日付を設定（2026年10月6日）
        DateTime baseDate = new DateTime(2026, 10, 6);

        // 2. 30日後を計算
        DateTime result = baseDate.AddDays(30);

        // 3. 計算結果が「2026年11月5日」になっているか自動判定！
        Assert.AreEqual(new DateTime(2026, 11, 5), result);
    }
}