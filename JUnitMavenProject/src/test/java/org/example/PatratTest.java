package org.example;

import org.junit.jupiter.api.*;
import org.junit.jupiter.params.ParameterizedTest;
import org.junit.jupiter.params.provider.CsvFileSource;
import org.junit.jupiter.params.provider.CsvSource;
import org.junit.jupiter.params.provider.MethodSource;
import org.junit.jupiter.params.provider.ValueSource;

import java.util.Arrays;
import java.util.List;

import static org.junit.jupiter.api.Assertions.*;
class PatratTest {
    Patrat p;

    @BeforeAll
    static void testInainteDeToate() {
        System.out.println("facem teste");
    }

    @BeforeEach
    void setUp() {

    }

    @AfterEach
    void tearDown() {
    }

    @Test
    void calculeazaAria() {
        Patrat p = new Patrat(2.5);
        assertEquals(6.25,p.calculeazaAria());
    }

    @Test
    void calculeazaPerimetrul() {
        Patrat p = new Patrat(2);
        assertEquals(8,p.calculeazaPerimetrul());
    }

    @Test
    void testConstructorImplicit() {
        Patrat p = new Patrat();
        assertAll(
                () -> assertNotNull(p),
                () -> assertEquals(1.0,p.latura),
                () -> assertTrue(1.0 == p.calculeazaAria())
        );
    }
    @Test
    @DisplayName("Verifica daca arunca erori")
    void testConstructor2ParamNegativ() {
        assertAll(
                () -> assertNotNull(p, "este null"),
                () -> assertThrows(RuntimeException.class, () -> {
                    Patrat p = new Patrat();
                }, "numar pozitiv, nu arunca eroare"),
                () -> assertThrows(RuntimeException.class, () -> {
                    Patrat p = new Patrat(-3.5);
                }, "numar pozitiv, nu arunca eroare"),
                () -> assertDoesNotThrow(() -> {
                    Patrat p = new Patrat(3.5);
                })
        );
    }

    @RepeatedTest(value = 10, failureThreshold = 3)
    void testRepetat(){
        Patrat p = new Patrat(3);
        assertEquals(8,p.calculeazaPerimetrul());
    }
}

class testeParametrizate
{
    @ParameterizedTest
    @ValueSource(doubles = {3, 2, 5})
    void testParametrizatValori(double number) {
        Patrat p = new Patrat(2);
        assertEquals(number,p.latura);
    }

    @ParameterizedTest
    @MethodSource("listaLaturi")
    void testParametrizatMetoda(Double lat) {
        assertThrows(RuntimeException.class, () -> {Patrat p = new Patrat(lat);}, "numar pozitiv, nu arunca eroare");
    }

    static public List<Double> listaLaturi()
    {
        return Arrays.asList(-2.0, 1.2, -2.4);
    }

    @ParameterizedTest
    @CsvSource({"-2.0", "1.2", "3", "-2.4"})
    void testParametrizatCSV(Double lat) {
        assertThrows(RuntimeException.class, () -> {Patrat p = new Patrat(lat);}, "numar pozitiv, nu arunca eroare");

    }

    @ParameterizedTest
    @CsvFileSource(resources = "/data.csv")
    void testParametrizatCSVFile(Double lat) {
        assertThrows(RuntimeException.class, () -> {Patrat p = new Patrat(lat);}, "numar pozitiv, nu arunca eroare");

    }
}