$(document).ready(function () {

    // just for the demos, avoids form submit
    jQuery.validator.setDefaults({
        debug: true,
        success: "valid"
    });

    $("#form1").validate({
        rules:{
            F_M_L_Veteran: 'required',
            F_M_L_Claimant: 'required',
            Rel_Of_Cl_Vet: 'required',
            F_M_L_Veteran: 'required',
            Vet_SSN: 'required',
            Cla_SSN: 'required',
            Claim_Num: 'required',
            Date_Of_Exam: 'required',
            Home_Address: 'required',
            //DateAdmitted:'required'
            CompleteDiagnosis: 'required',
            Age: {
                required: true,
                number: true,
                min: 1,
                max: 99
            },
            Sex: {
                required: true
            },
            Weight_Actual_Lbs: {
                required: true,
                number: true,
                max: 200
            },
            Weight_Estimated_Lbs:{
                required: true,
                number: true,
                max: 200
            },
            Height_Feet:{

                required: true,
                number: true,
                max:8
            },
            Height_Inches: {
                required: true,
                number: true,
                max: 90
            },
            Nutrition: {
                required:true
            }
            ,
            Gait: 'required',
            Blood_Presuure: {
                required: true,
                number:true
            },
            Pulse_Rate: {
                required: true,
                number: true
            },
            Resp_Rate: {
                required: true,
                number: true
            },
            Dis_Act: 'required',
            PostureAndGeneralAppearance: 'required',
            RestrictionsOfUpperExtremity: 'required',
            RestrictionsOfLowerExtremity: 'required',
            Restriction_Of_Spine_trunk_Neck: 'required',
            The_Loss_Of_Bowel: 'required',
            Claimant_Circumtances: 'required',
            Printed_Name_Examiner: 'required',
            SignatureExaminer: {
                required: true,
                accept:'image/jpeg'
            },
            DateSigned: 'required',
            Name_And_Address_Medical_Facility: 'required',
            PhoneNumberMedicalFacility: {
                required: true,
                number:true
            }
        },
        messages: {
            F_M_L_Veteran: 'Please Enter Name for Veteran!',
            F_M_L_Claimant: 'Please Enter Name for Claimant!',
            Rel_Of_Cl_Vet: 'Please Enter This Field!',
            Vet_SSN: 'Please Enter This Field!',
            Cla_SSN: 'Please Enter This Field!',
            Claim_Num: 'Please Enter Valid Number from Claim!',
            Date_Of_Exam: 'Please Selecte Date!',
            Home_Address: 'Please Enter Valid Address',
            //DateAdmitted:'required'
            CompleteDiagnosis: 'Please Enter Full Details for Diagnosis!',
            
            Nutrition: 'Please Enter Valid Nutrition Details!'
            ,
            SignatureExaminer: 'Select JPG File Only!',
            DateSigned: 'Selecte Date of Signature!',
            Name_And_Address_Medical_Facility: 'Enter Valid Address!',
            PhoneNumberMedicalFacility:'Enter Valid Phone Number!'
        }
        
    });
});