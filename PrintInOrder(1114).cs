class Foo {
public:
    bool firstPrinted;
    bool secondPrinted;
    Foo() {
        firstPrinted = false;
        secondPrinted = false;
    }

    void first(function<void()> printFirst) {
        
        // printFirst() outputs "first". Do not change or remove this line.
        printFirst();
        firstPrinted = true;
    }

    void second(function<void()> printSecond) {
        
        // printSecond() outputs "second". Do not change or remove this line.
        while(firstPrinted == false){
            continue;
        }
        printSecond();
        secondPrinted = true;
    }

    void third(function<void()> printThird) {
        
        // printThird() outputs "third". Do not change or remove this line.
        while(secondPrinted == false){
            continue;
        }
        printThird();
    }
};