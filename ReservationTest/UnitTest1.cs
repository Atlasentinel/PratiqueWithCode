using EvaluationSampleCode;

namespace ReservationTest
{
    [TestClass]
    public class UnitTest1
    {
        private Reservation _reservation;

        [TestMethod]
        public void CanBeCancelledBy_WhenUserIsAdminOrReservationMadeByUser_ShouldBeTrue()
        {
            var _user = new User();
            _user.IsAdmin = true;
            _reservation = new Reservation(_user);
            Assert.IsTrue(_reservation.CanBeCancelledBy(_user));
        }

        [TestMethod]
        public void CanBeCancelledBy_WhenUserIsAdminOrReservationMadeByUser_ShouldBeFalse()
        {
            var _user1 = new User();
            var _user2 = new User();
            _reservation = new Reservation(_user1);
            _reservation.MadeBy = _user1;
            Assert.IsFalse(_reservation.CanBeCancelledBy(_user2));
        }
    }
}