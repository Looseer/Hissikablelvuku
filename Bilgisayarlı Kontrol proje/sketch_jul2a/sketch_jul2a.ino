#include <OneWire.h>
#include <DallasTemperature.h>
#include <LiquidCrystal.h>

// Sıcaklık sensörünün pinini belirtin
const int sensorPin = 2;

// LCD ekranın pinlerini belirtin
LiquidCrystal lcd(12, 11, 5, 4, 3, 2);

// DS18B20 sıcaklık sensörü nesnesi oluşturun
OneWire oneWire(sensorPin);
DallasTemperature sensors(&oneWire);

void setup() {
  // LCD ekranı başlatın
  lcd.begin(16, 2);

  // Sıcaklık sensörünü başlatın
  sensors.begin();
}

void loop() {
  // Sıcaklık değerini okuyun
  sensors.requestTemperatures();
  float celsius = sensors.getTempCByIndex(0);
  float fahrenheit = sensors.toFahrenheit(celsius);

  // LCD ekranına yazdırın
  lcd.setCursor(0, 0);
  lcd.print("C: " + String(celsius, 2) + "  ");
  lcd.setCursor(0, 1);
  lcd.print("F: " + String(fahrenheit, 2) + "  ");

  delay(1000); // 1 saniye bekle
}