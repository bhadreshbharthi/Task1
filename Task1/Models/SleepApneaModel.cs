using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Task1.Models
{
    public class SleepApneaModel
    {
        //sectionI
        public string SleepApnea { get; set; }
        public bool DIAGNOSIS_SLEEP_APNEA_OBSTRUCTIVE { get; set; }
        public string DIAGNOSIS_SLEEP_APNEA_OBSTRUCTIVE_ICD { get; set; }
        public string DIAGNOSIS_SLEEP_APNEA_OBSTRUCTIVE_DATE { get; set; }
        public bool DIAGNOSIS_SLEEP_APNEA_CENTRAL { get; set; }
        public string DIAGNOSIS_SLEEP_APNEA_CENTRAL_ICD { get; set; }
        public string DIAGNOSIS_SLEEP_APNEA_CENTRAL_DATE { get; set; }
        public bool DIAGNOSIS_SLEEP_APNEA_MIXED { get; set; }
        public string DIAGNOSIS_SLEEP_APNEA_MIXED_ICD { get; set; }
        public string DIAGNOSIS_SLEEP_APNEA_MIXED_DATE { get; set; }
        public bool DIAGNOSIS_SLEEP_APNEA_OTHER { get; set; }
        public string DIAGNOSIS_SLEEP_APNEA_OTHER_ICD { get; set; }
        public string DIAGNOSIS_SLEEP_APNEA_OTHER_DATE { get; set; }
        public string DIAGNOSIS_SLEEP_APNEA_OTHER_EDIT { get; set; }
        public string DIAGNOSIS_SLEEP_APNEA_ADDITIONAL { get; set; }
        //sectionII
        public string HISTORY_SLEEP_APNEA_DESCRIBE { get; set; }
        public string HISTORY_SLEEP_APNEA_MEDS { get; set; }
        public string HISTORY_SLEEP_APNEA_MEDS_DESCRIBE { get; set; }
        public string SleepApneaContinuousPositiveAirwayPressureMachine { get; set; }
        //SectionIII
        public string SleepApneaFindings { get; set; }
        public bool SleepApneaPersistentDaytimeHypersomnolence { get; set; }
        public bool SleepApneaCardonDioxideRetention { get; set; }
        public bool SleepApneaChronicRespiratoryFailure { get; set; }
        public bool SleepApneaCorPulmonale { get; set; }
        public bool SleepApneaRequiresTracheostomy { get; set; }
        public bool EXAM_SLEEP_APNEA_FINDINGS_OTHER { get; set; }
        public string EXAM_SLEEP_APNEA_FINDINGS_OTHER_DESCRIBE { get; set; }
        //SectionIV
        public string EXAM_SLEEP_APNEA_OPP_OTHER_PERT { get; set; }
        public string EXAM_SLEEP_APNEA_OPP_OTHER_PERT_DESCRIBE { get; set; }
        public string EXAM_SLEEP_APNEA_OPP_SCARS { get; set; }
        public string EXAM_SLEEP_APNEA_OPP_SCARS_YES { get; set; }
        public string EXAM_SLEEP_APNEA_OPP_SCARS_LOCATION { get; set; }
        public string EXAM_SLEEP_APNEA_OPP_SCARS_LENGTH { get; set; }
        public string EXAM_SLEEP_APNEA_OPP_SCARS_WIDTH { get; set; }
        public string EXAM_SLEEP_APNEA_OPP_SCARS_ADDITIONAL_COMMENTS { get; set; }
        //SectionV
        public string EXAM_SLEEP_APNEA_DT_SLEEP_STUDY { get; set; }
        public string SleepApneaDocumentedSleepDisorderBreathing { get; set; }
        public string EXAM_SLEEP_APNEA_DT_SLEEP_STUDY_DATE { get; set; }
        public string EXAM_SLEEP_APNEA_DT_SLEEP_STUDY_FACILITY { get; set; }
        public string EXAM_SLEEP_APNEA_DT_SLEEP_STUDY_RESULTS { get; set; }
        public string EXAM_SLEEP_APNEA_DT_OTHER_SIGN { get; set; }
        public string EXAM_SLEEP_APNEA_DT_OTHER_SIGN_DESCRIBE { get; set; }
        //SectionVI
        public string EXAM_SLEEP_APNEA_FI { get; set; }
        public string EXAM_SLEEP_APNEA_FI_DESCRIBE { get; set; }
        //SectionVII
        public string EXAM_SLEEP_APNEA_REMARKS { get; set; }
        //SectionVIII from DBQ.CS

    }
}