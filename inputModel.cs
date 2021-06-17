using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ML.Data;
namespace Project_1
{
    class inputModel
    {
        [LoadColumn(0)]
        public float itching { get; set; }
        [LoadColumn(1)]
        public float skin_rash { get; set; }
        [LoadColumn(2)]
        public float nodal_skin_eruptions { get; set; }
        [LoadColumn(3)]
        public float continuous_sneezing { get; set; }
        [LoadColumn(4)]
        public float shivering { get; set; }
        [LoadColumn(5)]
        public float chills { get; set; }
        [LoadColumn(6)]
        public float joint_pain { get; set; }
        [LoadColumn(7)]
        public float stomach_pain { get; set; }
        [LoadColumn(8)]
        public float acidity { get; set; }
        [LoadColumn(9)]
        public float ulcers_on_tongue { get; set; }
        [LoadColumn(10)]
        public float muscle_wasting { get; set; }
        [LoadColumn(11)]
        public float vomiting { get; set; }
        [LoadColumn(12)]
        public float burning_micturition { get; set; }
        [LoadColumn(13)]
        public float spotting_urination { get; set; }
        [LoadColumn(14)]
        public float fatigue { get; set; }
        [LoadColumn(15)]
        public float weight_gain { get; set; }
        [LoadColumn(16)]
        public float anxiety { get; set; }
        [LoadColumn(17)]
        public float cold_hands_and_feets { get; set; }
        [LoadColumn(18)]
        public float mood_swings { get; set; }
        [LoadColumn(19)]
        public float weight_loss { get; set; }
        [LoadColumn(20)]
        public float restlessness { get; set; }
        [LoadColumn(21)]
        public float lethargy { get; set; }
        [LoadColumn(22)]
        public float patches_in_throat { get; set; }
        [LoadColumn(23)]
        public float irregular_sugar_level { get; set; }
        [LoadColumn(24)]
        public float cough { get; set; }
        [LoadColumn(25)]
        public float high_fever { get; set; }
        [LoadColumn(26)]
        public float sunken_eyes { get; set; }
        [LoadColumn(27)]
        public float breathlessness { get; set; }
        [LoadColumn(28)]
        public float sweating { get; set; }
        [LoadColumn(29)]
        public float dehydration { get; set; }
        [LoadColumn(30)]
        public float indigestion { get; set; }
        [LoadColumn(31)]
        public float headache { get; set; }
        [LoadColumn(32)]
        public float yellowish_skin { get; set; }
        [LoadColumn(33)]
        public float dark_urine { get; set; }
        [LoadColumn(34)]
        public float nausea { get; set; }
        [LoadColumn(35)]
        public float loss_of_appetite { get; set; }
        [LoadColumn(36)]
        public float pain_behind_the_eyes { get; set; }
        [LoadColumn(37)]
        public float back_pain { get; set; }
        [LoadColumn(38)]
        public float constipation { get; set; }
        [LoadColumn(39)]
        public float abdominal_pain { get; set; }
        [LoadColumn(40)]
        public float diarrhoea { get; set; }
        [LoadColumn(41)]
        public float mild_fever { get; set; }
        [LoadColumn(42)]
        public float yellow_urine { get; set; }
        [LoadColumn(43)]
        public float yellowing_of_eyes { get; set; }
        [LoadColumn(44)]
        public float acute_liver_failure { get; set; }
        [LoadColumn(45)]
        public float fluid_overload { get; set; }
        [LoadColumn(46)]
        public float swelling_of_stomach { get; set; }
        [LoadColumn(47)]
        public float swelled_lymph_nodes { get; set; }
        [LoadColumn(48)]
        public float malaise { get; set; }
        [LoadColumn(49)]
        public float blurred_and_distorted_vision { get; set; }
        [LoadColumn(50)]
        public float phlegm { get; set; }
        [LoadColumn(51)]
        public float throat_irritation { get; set; }
        [LoadColumn(52)]
        public float redness_of_eyes { get; set; }
        [LoadColumn(53)]
        public float sinus_pressure { get; set; }
        [LoadColumn(54)]
        public float runny_nose { get; set; }
        [LoadColumn(55)]
        public float congestion { get; set; }
        [LoadColumn(56)]
        public float chest_pain { get; set; }
        [LoadColumn(57)]
        public float weakness_in_limbs { get; set; }
        [LoadColumn(58)]
        public float fast_heart_rate { get; set; }
        [LoadColumn(59)]
        public float pain_during_bowel_movements { get; set; }
        [LoadColumn(60)]
        public float pain_in_anal_region { get; set; }
        [LoadColumn(61)]
        public float bloody_stool { get; set; }
        [LoadColumn(62)]
        public float irritation_in_anus { get; set; }
        [LoadColumn(63)]
        public float neck_pain { get; set; }
        [LoadColumn(64)]
        public float dizziness { get; set; }
        [LoadColumn(65)]
        public float cramps { get; set; }
        [LoadColumn(66)]
        public float bruising { get; set; }
        [LoadColumn(67)]
        public float obesity { get; set; }
        [LoadColumn(68)]
        public float swollen_legs { get; set; }
        [LoadColumn(69)]
        public float swollen_blood_vessels { get; set; }
        [LoadColumn(70)]
        public float puffy_face_and_eyes { get; set; }
        [LoadColumn(71)]
        public float enlarged_thyroid { get; set; }
        [LoadColumn(72)]
        public float brittle_nails { get; set; }
        [LoadColumn(73)]
        public float swollen_extremeties { get; set; }
        [LoadColumn(74)]
        public float excessive_hunger { get; set; }
        [LoadColumn(75)]
        public float extra_marital_contacts { get; set; }
        [LoadColumn(76)]
        public float drying_and_tingling_lips { get; set; }
        [LoadColumn(77)]
        public float slurred_speech { get; set; }
        [LoadColumn(78)]
        public float knee_pain { get; set; }
        [LoadColumn(79)]
        public float hip_joint_pain { get; set; }
        [LoadColumn(80)]
        public float muscle_weakness { get; set; }
        [LoadColumn(81)]
        public float stiff_neck { get; set; }
        [LoadColumn(82)]
        public float swelling_joints { get; set; }
        [LoadColumn(83)]
        public float movement_stiffness { get; set; }
        [LoadColumn(84)]
        public float spinning_movements { get; set; }
        [LoadColumn(85)]
        public float loss_of_balance { get; set; }
        [LoadColumn(86)]
        public float unsteadiness { get; set; }
        [LoadColumn(87)]
        public float weakness_of_one_body_side { get; set; }
        [LoadColumn(88)]
        public float loss_of_smell { get; set; }
        [LoadColumn(89)]
        public float bladder_discomfort { get; set; }
        [LoadColumn(90)]
        public float foul_smell_ofurine { get; set; }
        [LoadColumn(91)]
        public float continuous_feel_of_urine { get; set; }
        [LoadColumn(92)]
        public float passage_of_gases { get; set; }
        [LoadColumn(93)]
        public float internal_itching { get; set; }
        [LoadColumn(94)]
        public float toxic_look_typhos { get; set; }
        [LoadColumn(95)]
        public float depression { get; set; }
        [LoadColumn(96)]
        public float irritability { get; set; }
        [LoadColumn(97)]
        public float muscle_pain { get; set; }
        [LoadColumn(98)]
        public float altered_sensorium { get; set; }
        [LoadColumn(99)]
        public float red_spots_over_body { get; set; }
        [LoadColumn(100)]
        public float belly_pain { get; set; }
        [LoadColumn(101)]
        public float abnormal_menstruation { get; set; }
        [LoadColumn(102)]
        public float dischromic_patches
        { get; set; }
        [LoadColumn(103)]
        public float watering_from_eyes { get; set; }
        [LoadColumn(104)]
        public float increased_appetite { get; set; }
        [LoadColumn(105)]
        public float polyuria { get; set; }
        [LoadColumn(106)]
        public float family_history { get; set; }
        [LoadColumn(107)]
        public float mucoid_sputum { get; set; }
        [LoadColumn(108)]
        public float rusty_sputum { get; set; }
        [LoadColumn(109)]
        public float lack_of_concentration { get; set; }
        [LoadColumn(110)]
        public float visual_disturbances { get; set; }
        [LoadColumn(111)]
        public float receiving_blood_transfusion { get; set; }
        [LoadColumn(112)]
        public float receiving_unsterile_injections { get; set; }
        [LoadColumn(113)]
        public float coma { get; set; }
        [LoadColumn(114)]
        public float stomach_bleeding { get; set; }
        [LoadColumn(115)]
        public float distention_of_abdomen { get; set; }
        [LoadColumn(116)]
        public float history_of_alcohol_consumption { get; set; }
        [LoadColumn(117)]
        public float Fluid_overload { get; set; }
        [LoadColumn(118)]
        public float blood_in_sputum { get; set; }
        [LoadColumn(119)]
        public float prominent_veins_on_calf { get; set; }
        [LoadColumn(120)]
        public float palpitations { get; set; }
        [LoadColumn(121)]
        public float painful_walking { get; set; }
        [LoadColumn(122)]
        public float pus_filled_pimples { get; set; }

        [LoadColumn(123)]
        public float blackheads { get; set; }
        [LoadColumn(124)]
        public float scurring { get; set; }
        [LoadColumn(125)]
        public float skin_peeling { get; set; }
        [LoadColumn(126)]
        public float silver_like_dusting { get; set; }
        [LoadColumn(127)]
        public float small_dents_in_nails { get; set; }
        [LoadColumn(128)]
        public float inflammatory_nails { get; set; }
        [LoadColumn(129)]
        public float blister { get; set; }
        [LoadColumn(130)]
        public float red_sore_around_nose { get; set; }
        [LoadColumn(131)]
        public float yellow_crust_ooze { get; set; }
        [LoadColumn(132), ColumnName("predict")]
        public string prediction { get; set; }


    }

}
