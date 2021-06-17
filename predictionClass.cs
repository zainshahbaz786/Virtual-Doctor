using Microsoft.ML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.ML.DataOperationsCatalog;

namespace Project_1
{
    class predictionClass
    {
        private string predict;

        public string Predict { get => predict; set => predict = value; }

        public void illness(inputModel obj)
        {
            MLContext mlC = new MLContext();

            //3)
            IDataView trainingDataView = mlC.Data.LoadFromTextFile<inputModel>(Properties.Settings.Default.trainingPath, hasHeader: false, separatorChar: ',');


            //4)
            var partition = mlC.Data.TrainTestSplit(trainingDataView, 0.2);
           // var Feature = partition.TrainSet.Schema.Select();
            string featureColumnName = "Features";
            var dataPreparationPipeline = mlC.Transforms.Conversion.MapValueToKey(inputColumnName:"predict",outputColumnName:"Label")
                
                .Append(mlC.Transforms.Concatenate(featureColumnName, "itching", "skin_rash", "nodal_skin_eruptions", "continuous_sneezing", "shivering", "chills", "joint_pain", "stomach_pain", "ulcers_on_tongue", "muscle_wasting", "vomiting", "burning_micturition", "spotting_urination", "fatigue", "weight_gain", "anxiety", "cold_hands_and_feets", "mood_swings", "weight_loss", "restlessness", "lethargy", "patches_in_throat", "irregular_sugar_level", "cough", "high_fever", "sunken_eyes", "breathlessness", "sweating", "dehydration", "indigestion", "headache", "yellowish_skin", "dark_urine", "nausea", "loss_of_appetite", "pain_behind_the_eyes", "back_pain", "constipation", "abdominal_pain", "diarrhoea", "mild_fever", "yellow_urine", "yellowing_of_eyes", "acute_liver_failure", "fluid_overload", "swelling_of_stomach",
  "swelled_lymph_nodes", "malaise", "blurred_and_distorted_vision", "phlegm", "throat_irritation", "redness_of_eyes", "sinus_pressure", "runny_nose", "congestion", "chest_pain", "weakness_in_limbs", "fast_heart_rate", "pain_during_bowel_movements", "pain_in_anal_region", "bloody_stool", "irritation_in_anus", "neck_pain", "dizziness", "cramps", "bruising", "obesity", "swollen_legs", "swollen_blood_vessels", "puffy_face_and_eyes", "enlarged_thyroid", "brittle_nails", "swollen_extremeties", "excessive_hunger", "extra_marital_contacts", "drying_and_tingling_lips", "slurred_speech", "knee_pain", "hip_joint_pain", "muscle_weakness", "stiff_neck", "swelling_joints", "movement_stiffness", "spinning_movements", "loss_of_balance", "unsteadiness", "weakness_of_one_body_side", "loss_of_smell", "bladder_discomfort", "foul_smell_ofurine", "continuous_feel_of_urine", "passage_of_gases", "internal_itching", "toxic_look_typhos", "depression", "irritability", "muscle_pain", "altered_sensorium", "red_spots_over_body", "belly_pain", "abnormal_menstruation", "dischromic_patches", "watering_from_eyes", "increased_appetite", "polyuria", "family_history", "mucoid_sputum", "rusty_sputum", "lack_of_concentration", "visual_disturbances", "receiving_blood_transfusion", "receiving_unsterile_injections", "coma", "stomach_bleeding", "distention_of_abdomen", "history_of_alcohol_consumption", "Fluid_overload", "blood_in_sputum", "prominent_veins_on_calf", "palpitations", "painful_walking", "pus_filled_pimples", "blackheads", "scurring", "skin_peeling", "silver_like_dusting", "small_dents_in_nails", "inflammatory_nails", "blister", "red_sore_around_nose", "yellow_crust_ooze"))
                .AppendCacheCheckpoint(mlC);


            //5)
            var naiveBayesMultiClassTrainer = dataPreparationPipeline.Append(mlC.MulticlassClassification.Trainers.NaiveBayes(labelColumnName: "Label", featureColumnName: featureColumnName)).Append(mlC.Transforms.Conversion.MapKeyToValue("PredictedLabel"));


            //6)
            TrainTestData trainTestData = mlC.Data.TrainTestSplit(trainingDataView, testFraction: 0.2);

            //7)
            var model = naiveBayesMultiClassTrainer.Fit(trainTestData.TrainSet);

            //8)Evaluation of Trained Model
            var metrices = mlC.MulticlassClassification.Evaluate(model.Transform(trainTestData.TestSet));


            //9) Displaying performance metrices of Model



           


            //10)
            inputModel predictionData = new inputModel();
            {
                
                {

                    predictionData.itching = 1;
                    predictionData.nodal_skin_eruptions = 1;
                    predictionData.skin_rash = 1;
                }



            }

            //11)

            var predictor = mlC.Model.CreatePredictionEngine<inputModel, OutputModel>(model);


            //12
            var predictedClassofDisease = predictor.Predict(obj);

            //13)


            Predict = string.Join("", predictedClassofDisease.predictedlabels.ToString());
            // obj()

         

            


        }








    }
}
