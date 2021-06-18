using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPSoundApp.Model
{
    public static class SoundManager
    {
        public static void GetAllSounds(ObservableCollection<Sound> sounds)
        {
           var Allsounds = getSounds();
            sounds.Clear();
            
            Allsounds.ForEach(sound => sounds.Add(sound));
        }

        public static void GetAllSoundsByCategory(ObservableCollection<Sound> sounds,SoundCategory category)
        {
            var Allsounds = getSounds();
            sounds.Clear();

            var filteredSounds = Allsounds.Where(sound => sound.Category == category).ToList();
            filteredSounds.ForEach(sound => sounds.Add(sound));
        }

        private static List<Sound> getSounds()
        {
            var sounds = new List<Sound>();
            
            sounds.Add(new Sound("Cat", SoundCategory.Animals));
            sounds.Add(new Sound("Cow", SoundCategory.Animals));
            sounds.Add(new Sound("Gun", SoundCategory.Cartoons));
            sounds.Add(new Sound("Spring", SoundCategory.Cartoons));
            sounds.Add(new Sound("Clock", SoundCategory.Taunts));
            sounds.Add(new Sound("LOL", SoundCategory.Taunts));
            sounds.Add(new Sound("Ship", SoundCategory.Warnings));
            sounds.Add(new Sound("Siren", SoundCategory.Warnings));

            return sounds;
        }
    }
}
