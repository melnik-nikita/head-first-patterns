namespace Facade
{
    public static class HomeTheaterTestDrive
    {
        public static void Test()
        {
            var amp = new Amplifier();
            var tuner = new Tuner();
            var dvd = new DvdPlayer();
            var cd = new CdPlayer();
            var projector = new Projector();
            var screen = new Screen();
            var lights = new TheaterLights();
            var popper = new PopcornPopper();

            var homeTheaterFacade = new HomeTheaterFacade(
                amp, tuner, dvd, cd, projector, screen, lights, popper
            );

            homeTheaterFacade.WatchMovie("Raiders of the Lost Ark");
            homeTheaterFacade.EndMovie();
        }
    }
}
