using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Task1.Models
{
    public class AidAndAttendance
    {

        // SECTION I 
        //[Required]
        public string F_M_L_Veteran { get; set; }

        //[Required]
        public string F_M_L_Claimant { get; set; }

        //[Required]
        public string Rel_Of_Cl_Vet { get; set; }


        //[Required]
        public string Vet_SSN { get; set; }

        //[Required]
        public string Cla_SSN { get; set; }


        //[Required]
        public string Claim_Num { get; set; }

        [DataType(DataType.Date)]
        //[Required]
        public string Date_Of_Exam { get; set; }

        [DataType(DataType.MultilineText)]
        //[Required]
        public string Home_Address { get; set; }


        public string Is_Claimant_Hospitalized_Yes { get; set; }
        public string Is_Claimant_Hospitalized_No { get; set; }
        [DataType(DataType.Date)]

        public string DateAdmitted { get; set; }
        [DataType(DataType.MultilineText)]
        public string NameAndAddressOfHospital { get; set; }

        [DataType(DataType.MultilineText)]
        public string CompleteDiagnosis { get; set; }


        //[Required]
        //[RegularExpression("^[0-9]{1,3}$",ErrorMessage = "Enter Valid Age!")]
        public string Age { get; set; }

        //[Required]
        public string Sex { get; set; }

        //[Required]
        public string Weight_Actual_Lbs { get; set; }

        //[Required]
        public string Weight_Estimated_Lbs { get; set; }


        //[Required]
        public string Height_Feet { get; set; }


        //[Required]
        public string Height_Inches { get; set; }


        //[Required]
        [DataType(DataType.MultilineText)]
        public string Nutrition { get; set; }


        //[Required]
        public string Gait { get; set; }


        //[Required]
        public string Blood_Presuure { get; set; }


        //[Required]
        public string Pulse_Rate { get; set; }


        //[Required]
        public string Resp_Rate { get; set; }


        //[Required]
        public string Dis_Act { get; set; }

        public string Ind_Num_Bed_9pmto5am { get; set; }

        public string Ind_Num_Bed_9amto5pm { get; set; }

        public string Claimant_feed_Yes { get; set; }

        public string Claimant_feed_No { get; set; }

        [DataType(DataType.MultilineText)]
        public string Claimant_No_Describe { get; set; }

        public string Claimant_Prep_Meal_Yes { get; set; }

        public string Claimant_Prep_Meal_No { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Claimant Prep Meal No Describe")]
        public string Claimant_Prep_Meal_No_Describe { get; set; }

        public string Claimant_Assistance_Yes { get; set; }

        public string Claimant_Assistance_No { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Claimant Assistance Yes Describe")]
        public string Claimant_Assistance_Yes_Describe { get; set; }

        public string Claimant_Legally_Blind_Yes { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Claimant Legally Blind Yes Describe")]
        public string Claimant_Legally_Blind_Yes_Describe { get; set; }

        [Display(Name = "Claimant Legally Blind No")]
        public string Claimant_Legally_Blind_No { get; set; }

        [Display(Name = "Corrected Vision Left Eye")]
        public string CorrectedVisionLeftEye { get; set; }
        [Display(Name = "Corrected Vision Right Eye")]
        public string CorrectedVisionRightEye { get; set; }

        [Display(Name = "Claimant Care Yes")]
        public string Claimant_Care_Yes { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Claimant Care Yes Describe")]
        public string Claimant_Care_Yes_Describe { get; set; }

        public string Claimant_Care_No { get; set; }

        [Display(Name = "Claimant Medication Managemant Yes")]
        public string Claimant_Medication_Managemant_Yes { get; set; }
        [DataType(DataType.MultilineText)]
        [Display(Name = "Claimant Medication Managemant Yes Describe")]
        public string Claimant_Medication_Managemant_Yes_Describe { get; set; }

        [Display(Name = "Claimant MedicationManagement No")]
        public string Claimant_MedicationManagement_No { get; set; }

        [Display(Name = "Claimant Ability Financial Yes")]
        public string Claimant_Ability_Financial_Yes { get; set; }

        [Display(Name = "Claimant Ability Financial No")]
        public string Claimant_Ability_Financial_No { get; set; }
        [DataType(DataType.MultilineText)]
        [Display(Name = "Claimant Ability Financial No Describe")]
        public string Claimant_Ability_Financial_No_Describe { get; set; }


        //[Required]
        [Display(Name = "Posture and General Appearance")]
        public string PostureAndGeneralAppearance { get; set; }


        //[Required]
        [Display(Name = "Restrictions Of Upper Extremity")]
        public string RestrictionsOfUpperExtremity { get; set; }


        //[Required]
        [Display(Name = "Restrictions Of Lower Extremity")]
        public string RestrictionsOfLowerExtremity { get; set; }


        //[Required]
        [Display(Name = "Restriction Of Spine trunk Neck")]
        public string Restriction_Of_Spine_trunk_Neck { get; set; }


        //[Required]
        public string The_Loss_Of_Bowel { get; set; }


        //[Required]
        public string Claimant_Circumtances { get; set; }

        public string Locomotion_Yes { get; set; }
        public bool Locomotion_Yes_1Block { get; set; }

        public bool Locomotion_Yes_5_6Block { get; set; }
        public bool Locomotion_Yes_1Mile { get; set; }

        [Display(Name = "Locomotion Yes OtherSpecify")]
        public string Locomotion_Yes_OtherSpecify { get; set; }

        public string Locomotion_No { get; set; }
        //Section 2

        //[Required]
        public string Printed_Name_Examiner { get; set; }


        //[Required]
        public string SignatureExaminer { get; set; }


        //[Required]
        [DataType(DataType.Date)]
        public string DateSigned { get; set; }

        //[Required]
        [Display(Name = "Name and Address Medical Facility")]
        public string Name_And_Address_Medical_Facility { get; set; }

        //[Required]
        [Display(Name = "Phone Number Medical Facility")]
        public string PhoneNumberMedicalFacility { get; set; }

    }
}