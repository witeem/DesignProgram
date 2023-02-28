public sealed class SignleClass
{
    public string Name { get; set; }
    private static SignleClass mySignle;
    private static object Flag = new object();
    public static SignleClass GetSignle
    {
        get
        {
            // 判断是否被实例化
            if (mySignle == null)
            {
                // 进入锁
                lock (Flag)
                {
                    // 判断是否被实例化
                    if (mySignle == null)
                    {
                        mySignle = new SignleClass();
                    }
                }
            }

            return mySignle;
        }

    }
}