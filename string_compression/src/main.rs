fn string_compression(s: &str) -> String {
    let mut consecutive: i32 = 0;
    let mut compressed = "".to_string();

    let mut prev = s.chars().next().unwrap();
    for c in s.chars() {
        if c == prev {
            consecutive += 1;
        } else {
            compressed += format!("{}{}", prev, consecutive).as_str();
            consecutive = 1;
        }
        prev = c;
    }
    compressed += format!("{}{}", prev, consecutive).as_str();

    compressed
}

fn main() {
    let s = "aabcccccaaa";

    println!("{}", string_compression(s));
}
