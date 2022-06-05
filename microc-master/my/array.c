int main(int n) {
    int a[3];
    a[0] = 1999;
    a[2] = 1666;
    print a[0];
    print a[1];
    print a[2];
    print a[3]; // 实际越界但不会报错
    print a[-1]; // 实际越界但不会报错
}
