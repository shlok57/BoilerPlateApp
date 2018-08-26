namespace Shlok.Tests
{
	class TestTimeout
	{
		// Timeout of 200 ms for Unit Tests
		public const int Acceptable = 200;

		// Timeout of 1200 ms for longer Unit Tests
		public const int Appropriate = 1200;

		// Timeout of 12 s for Integretion Tests
		public const int Integretion = 12000;

		// Timeout of 30 s for Nightly Tests
		public const int Nightly = 30000;
	}
}
