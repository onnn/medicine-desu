using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BodyTest1
{
    class Symptoms
    {
        public ArrayList SymptomArray { set; get; } 
        public Symptoms()
        {
            SymptomArray = new ArrayList();
            
        }
    }

    class Rash : Symptom
    {
        public Rash()
        {
            Console.WriteLine("Patient complains of a rash.");
            
        }
    }

    class Itching : Symptom
    {
        public Itching()
        {
            Console.WriteLine("Patient complains of itchiness.");
        }
        
    }
    class ChangeInHair : Symptom
    {

    }
    class ChangeInNails : Symptom
    {

    }
    class Headaches : Symptom
    {

    }
    class HeadInjury : Symptom
    {

    }
    class Glasses : Symptom
    {

    }
    class Contacts : Symptom
    {

    }
    class ChangeInVision : Symptom
    {

    }
    
    class EyePain : Symptom
    {

    }
    class DoubleVision : Symptom
    {

    }
    class FlashingLights : Symptom
    {

    }
    class Glaucoma : Symptom
    {

    }
    class Cataracts : Symptom
    {

    }
    class EarPain : Symptom
    {

    }
    class ChangeInHearing : Symptom
    {

    }
    class EarDischarge : Symptom
    {

    }
    class Dizziness : Symptom
    {

    }
    class NoseBleeds : Symptom
    {

    }
    class NasalStuffiness : Symptom
    {

    }
    class FrequentColds : Symptom
    {

    }
    class Hives : Symptom
    {

    }
    class HayFever : Symptom
    {

    }
    class Asthma : Symptom
    {

    }
    class Eczema : Symptom
    {

    }
    class SensitiveSkin : Symptom
    {

    }
    class BleedingGums : Symptom
    {

    }
    class SoreTongue : Symptom
    {

    }
    class SoreThroat : Symptom
    {

    }
    class Hoarseness : Symptom
    {

    }
    class NeckLumps : Symptom
    {

    }
    class SwollenGlands : Symptom
    {

    }
    class Goiter : Symptom
    {

    }
    class NeckStiffness : Symptom
    {

    }
    class BreastLump : Symptom
    {

    }
    class BreastPain : Symptom
    {

    }
    class NippleDischarge : Symptom
    {

    }
    class ShortnessOfBreath : Symptom
    {

    }
    class Cough : Symptom
    {

    }
    class ProductionOfPhlegm : Symptom
    {

    }
    class Wheezing : Symptom
    {

    }
    class CoughingUpBlood : Symptom
    {

    }
    class ChestPain : Symptom
    {

    }
    class Fever : Symptom
    {

    }
    class NightSweats : Symptom
    {

    }
    class SwellingInExtremities : Symptom
    {

    }
    class BlueExtremities : Symptom
    {

    }
    class HighBloodPressure : Symptom
    {

    }
    class SkippingHeartBeats : Symptom
    {

    }
    class HeartMurmur : Symptom
    {

    }

    class Bronchitis : Symptom
    {

    }

    class Emphysema : Symptom
    {

    }

    class RheumaticHeartDisease : Symptom
    {

    }
    class AppetiteIncrease : Symptom
    {

    }
    class AppetiteDecrease : Symptom
    {

    }
    class WeightIncrease : Symptom
    {

    }
    class DifficultySwallowing : Symptom
    {

    }
    class Nausea : Symptom
    {

    }
    class Heartburn : Symptom
    {

    }
    class Vomiting : Symptom
    {

    }
    class VomitingBlood : Symptom
    {

    }
    class Constipation : Symptom
    {

    }
    class Diarrhea : Symptom
    {

    }
    class ChangeInBowelHabits : Symptom
    {

    }
    class AbdominalPain : Symptom
    {

    }
    class ExcessiveBelching : Symptom
    {

    }
    class ExcessiveFlatus : Symptom
    {

    }
    class YellowSkin : Symptom
    {

    }
    class FoodIntolerance : Symptom
    {

    }
    class RectalBleeding : Symptom
    {

    }
    class Hemorrhoids : Symptom
    {

    }
    class DifficultyUrinating : Symptom
    {

    }
    class PainfulUrination : Symptom
    {

    }
    class FrequentUrinationAtNight : Symptom
    {

    }
    class UrineIncontinence : Symptom
    {

    }
    class Dribbling : Symptom
    {

    }
    class DecreasedUrineStream : Symptom
    {

    }
    class BloodInUrine : Symptom
    {

    }
    class StonesInUrine : Symptom
    {

    }
    class LegCramps : Symptom
    {

    }
    class VaricoseVeins : Symptom
    {

    }
    class ClotsInVeins : Symptom
    {

    }
    class MusclePain : Symptom
    {

    }
    class MuscleSwelling : Symptom
    {

    }
    class MuscleStiffness : Symptom
    {

    }
    class DecreasedJointMotion : Symptom
    {

    }
    class BrokenBone : Symptom
    {
        public BrokenBone()
        {
            Console.WriteLine("Patient complains of a broken bone");
        }
    }
    class Sprain : Symptom
    {

    }
    class Arthritis : Symptom
    {

    }
    class Gout : Symptom
    {

    }
    class Seizures : Symptom
    {
        
    }
    class Paralysis : Symptom
    {

    }
    class Weakness : Symptom
    {

    }
    class LossOfMuscleSize : Symptom
    {

    }
    class Tremor : Symptom
    {

    }
    class InvoluntaryMovement : Symptom
    {

    }
    class Incoordination : Symptom
    {

    }
    class Numbness : Symptom
    {

    }
    class PinsAndNeedles : Symptom
    {

    }
    class Anemia : Symptom
    {


    }
    class EasyBruising : Symptom
    {

    }
    class AbnormalGrowth : Symptom
    {

    }
    class IncreasedThirst : Symptom
    {

    }
    class ThyroidTrouble : Symptom
    {

    }
    class HeatIntolerance : Symptom
    {

    }
    class ColdIntolerance : Symptom
    {

    }
    class ExcessiveSweating : Symptom
    {

    }
    class Diabetes : Symptom
    {

    }

    class Anxiety : Symptom
    {

    }
    class Depression : Symptom
    {


    }
    class SuicidalThoughts : Symptom
    {

    }
    class MemoryProblems : Symptom
    {

    }
    class SleepProblems : Symptom
    {

    }
    class ChangeInMood : Symptom
    {

    }
}
