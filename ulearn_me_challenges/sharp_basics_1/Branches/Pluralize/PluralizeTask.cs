namespace Pluralize
{
	public static class PluralizeTask
	{
		public static string PluralizeRubles(int count)
		{
			// Напишите функцию склонения слова "рублей" в зависимости от предшествующего числительного count.
		if (count < 10 || count > 20 && count < 100 )
            {
				int remains = count % 10;
				return (remains == 0 || remains > 4) ? "рублей" : ((remains > 1 && remains <= 4) ? "рубля" : "рубль");
            }
		else
            {
                while (true)
                {
                    count %= 100;
                    if (count < 100) break;
                }

                if (count < 10 || count > 20 && count < 100)
                {
                    int remains = count % 10;
                    return (remains == 0 || remains > 4) ? "рублей" : ((remains > 1 && remains <= 4) ? "рубля" : "рубль");
                }
                else
                {
                    return "рублей";
                }
            }
        }

	}
}