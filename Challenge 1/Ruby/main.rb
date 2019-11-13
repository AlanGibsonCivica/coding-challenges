
TESTS = [
  'HELLO WORLD',
  'SOMETHING ELSE',
  'ABCDEFG'
]

for test in TESTS do
  result = find_repeat_character(test)
  puts "#{test} : #{result}"
end


BEGIN {

  def find_repeat_character(input)
  end
  
}

