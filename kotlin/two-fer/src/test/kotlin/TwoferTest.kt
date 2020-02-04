package twoferpkg
import org.junit.Assert.assertEquals
import org.junit.Ignore
import org.junit.Test
class TwoferTest {
    var tf: Twofer = Twofer()

    @Test
    fun noNameGiven() {
        assertEquals("One for you, one for me.", tf.towfer())
    }

    @Test
    @Ignore
    fun aNameGiven() {
        assertEquals("One for Alice, one for me.", twofer("Alice"))
    }

    @Test
    @Ignore
    fun anotherNameGiven() {
        assertEquals("One for Bob, one for me.", twofer("Bob"))
    }

    @Test
    @Ignore
    fun emptyStringGiven() {
        assertEquals("One for , one for me.", twofer(""))
    }

}
