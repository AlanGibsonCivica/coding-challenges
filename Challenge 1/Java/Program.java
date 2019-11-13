public class Program {

  static String[] TESTS = {
    "HELLO WORLD",
    "SOMETHING ELSE",
    "ABCDEFG"
  };

  public static void main(String[] args) {
    for (String test : TESTS) {
      Character result = FindRepeatCharacter(test);
      System.out.println(
        String.format("%s : %s", test, result)
      );
    }
  }

  public static Character FindRepeatCharacter(String input) {
    return null;
  }
}