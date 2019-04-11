using System.Collections.Generic;

namespace Controls
{

    /// <summary>
    /// Used to generated random data.
    /// </summary>
    public class Generator
    {

        /// <summary>
        /// Generates random people data.
        /// </summary>
        /// <param name="count">Number of generated persons.</param>
        /// <returns>Collection of randomly generated persons.</returns>
        public IEnumerable<string> GetRandomPeople(int count)
        {
            for (int i = 0; i < count; i++)
            {
                yield return UselessLibrary.Generator.GeneratePerson();
            }
        }

        /// <summary>
        /// Generates random addresses.
        /// </summary>
        /// <param name="count">Number of generated addresses.</param>
        /// <returns>Collection of randomly generated addresses.</returns>
        public IEnumerable<string> GetRandomAddresses(int count)
        {
            for (int i = 0; i < count; i++)
            {
                yield return UselessLibrary.Generator.GenerateAddress();
            }
        }

        /// <summary>
        /// Generates random bank information.
        /// </summary>
        /// <param name="count">Number of generated bank information records.</param>
        /// <returns>Collection of randomly generated bank information records.</returns>
        public IEnumerable<string> GetRandomBanks(int count)
        {
            for (int i = 0; i < count; i++)
            {
                yield return UselessLibrary.Generator.GenerateBank();
            }
        }

    }

}
