w[1:4]  // word 4gram
c[1:4]  // class 4gram
w[1]-[1]w[1]	
w[1]-[2]w[1]
w[2]-[1]w[1]
w[1]-[1]w[2]
c[1]-[1]c[1]
c[1]-[2]c[1]
c[2]-[1]c[1]
c[1]-[1]c[2]
// long-skip bigram
w[1]-[3]w[1]
w[1]-[4]w[1]
c[1]-[3]c[1]
c[1]-[4]c[1]
// class predict word
c[1]w[1]
c[2]w[1]
c[3]w[1]


