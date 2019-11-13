
TESTS = [
  'HELLO WORLD',
  'SOMETHING ELSE',
  'ABCDEFG'
]

def main():
  for test in TESTS:
    result = find_repeat_character(test)
    print(f"{test} : {result}")


def find_repeat_character(input):
  return None



main()