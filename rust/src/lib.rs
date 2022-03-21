// #![feature(linkage)]

// #[linkage = "external"]
// #[export_name = "add_numbers"]
#[no_mangle]
pub extern fn add_numbers(number1: i32, number2: i32) -> i32 {
    println!("Hello from rust!");
    number1 + number2
}

#[repr(C)]
pub struct SampleStruct {
    pub field_one: i16,
    pub field_two: i32,
}

#[no_mangle]
pub extern fn get_simple_struct() -> SampleStruct {
    SampleStruct {
        field_one: 1,
        field_two: 2
    }
}
