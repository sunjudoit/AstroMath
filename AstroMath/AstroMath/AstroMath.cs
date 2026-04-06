namespace AstroMath
{
    public class AstroCalculations
    {
        // Constants
        private const double SpeedOfLight = 299792458.0;   // m/s
        private const double GravityConstant = 6.674e-11;  // N·m²/kg²

        /// <summary>
        /// Calculates the radial velocity of a star using the Doppler effect.
        /// Formula: v = c * (delta lambda / lambda0)
        /// </summary>
        /// <param name="observedWavelength">Observed wavelength of the star's light (nm)</param>
        /// <param name="restWavelength">Rest wavelength of the star's light (nm)</param>
        /// <returns>Radial velocity of the star (m/s)</returns>
        public double StarVelocity(double observedWavelength, double restWavelength)
        {
            double deltaLambda = observedWavelength - restWavelength;
            return SpeedOfLight * (deltaLambda / restWavelength);
        }

        /// <summary>
        /// Calculates the distance to a star using the parallax angle.
        /// Formula: d = 1 / p
        /// </summary>
        /// <param name="parallaxAngle">Parallax angle measured in arcseconds</param>
        /// <returns>Distance to the star in parsecs</returns>
        public double StarDistance(double parallaxAngle)
        {
            return 1.0 / parallaxAngle;
        }

        /// <summary>
        /// Converts a temperature from Celsius to Kelvin.
        /// Formula: K = C + 272.15
        /// </summary>
        /// <param name="celsius">Temperature in degrees Celsius</param>
        /// <returns>Temperature in Kelvin</returns>
        public double CelsiusToKelvin(double celsius)
        {
            return celsius + 272.15;
        }

        /// <summary>
        /// Calculates the Schwarzschild radius (event horizon) of a black hole.
        /// Formula: Rs = 2GM / c²
        /// </summary>
        /// <param name="mass">Mass of the black hole in kilograms</param>
        /// <returns>Schwarzschild radius in metres</returns>
        public double BlackholeEventHorizon(double mass)
        {
            return (2 * GravityConstant * mass) / (SpeedOfLight * SpeedOfLight);
        }
    }
}