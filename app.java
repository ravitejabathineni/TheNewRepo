import java.util.ArrayList;
import java.util.List;

// Define a Car class representing the blueprint for objects
class Car {
    private String brand;
    private int year;

    // Constructor to initialize the Car object
    public Car(String brand, int year) {
        this.brand = brand;
        this.year = year;
    }

    // Getter method for brand
    public String getBrand() {
        return brand;
    }

    // Method to display car details
    public void displayInfo() {
        System.out.println("Car Brand: " + brand + ", Year: " + year);
    }
}

// Main class containing the program's entry point
public class Main {
    public static void main(String[] args) {
        // 1. Create a dynamic list to store Car objects
        List<Car> carList = new ArrayList<>();

        // 2. Add instances of Car to the list
        carList.add(new Car("Toyota", 2021));
        carList.add(new Car("Tesla", 2024));
        carList.add(new Car("Ford", 2018));

        // 3. Iterate through the list using a standard for-each loop
        System.out.println("--- All Cars ---");
        for (Car car : carList) {
            car.displayInfo();
        }

        // 4. Use conditional logic to filter specific cars
        System.out.println("\n--- Filtered Search ---");
        for (Car car : carList) {
            if (car.getBrand().equals("Tesla")) {
                System.out.println("Found a Tesla! Showing info:");
                car.displayInfo();
            }
        }
    }
}
