#include <iostream>

extern "C" {
  void hello_world();
}

void hello_world() {
  std::cout << "Hello, world!" << std::endl;
}
