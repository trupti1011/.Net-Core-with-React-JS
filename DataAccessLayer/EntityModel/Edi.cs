using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModel
{
    public partial class Edi
    {
        public int EdiId { get; set; }
        public string Ediname { get; set; }
        public int FileFormatId { get; set; }
        public string TextQualifier { get; set; }
        public int RowTerminatorId { get; set; }
        public bool HasHeaders { get; set; }
        public string FileNameMask { get; set; }
        public string ProcessingLocation { get; set; }
        public string ArchiveLocation { get; set; }
        public string InvalidLocation { get; set; }
        public bool? SendErrorNotification { get; set; }
        public string EmailRecipients { get; set; }
        public bool IgnoreAllValidations { get; set; }
        public string StagingTableName { get; set; }
        public bool AddCheckSum { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool? IsImport { get; set; }
        public bool? SendSuccessNotification { get; set; }
        public bool? SendWarningNotification { get; set; }
        public bool? SendExportAsAttachment { get; set; }
        public int? EdicampaignUnitId { get; set; }
        public int? ReportingUnitId { get; set; }
        public string SheetName { get; set; }
        public bool ForceProcedureExecution { get; set; }
        public string SsispackageLocation { get; set; }
        public string ScheduleDeadlineTime { get; set; }
        public string XmlrootName { get; set; }
        public string XmlrecordName { get; set; }
        public bool AddExportOutputIntoEmailBody { get; set; }
        public bool Xmlxsinil { get; set; }
        public string SchedulePreDeadlineTime { get; set; }
        public bool? SendPreDeadlineNotification { get; set; }
        public bool? SendDeadlineNotification { get; set; }
        public string OnSuccessCustomNotification { get; set; }
        public string OnWarningCustomNotification { get; set; }
        public string OnErrorCustomNotification { get; set; }
        public string OnPreDeadlineCustomNotification { get; set; }
        public string OnDeadlineCustomNotification { get; set; }
        public bool IsFileZipped { get; set; }
        public bool StopSchedulesOnSuccess { get; set; }
        public bool PreValidateOnly { get; set; }
        public string OnPreValidateSuccessCustomNotification { get; set; }
        public bool? SendPreValidateSuccessNotification { get; set; }
        public bool ArchiveLoadedFiles { get; set; }
        public bool RemoveInvalidFiles { get; set; }
        public bool UseServiceBroker { get; set; }
        public bool LoopThroughImportFolder { get; set; }
        public bool AllowSameFileImport { get; set; }
        public long? RowsPerBatch { get; set; }
        public bool ReportNonMatchedFiles { get; set; }
        public bool? SendPreValidateErrorNotification { get; set; }
        public string OnPreValidateErrorCustomNotification { get; set; }
        public string Ftpaddress { get; set; }
        public long? Ftpport { get; set; }
        public string Ftpuser { get; set; }
        public string Ftppassword { get; set; }
        public string Ftpfolder { get; set; }
        public string SFtpkey { get; set; }
        public string ZipPassword { get; set; }
        public string ZipFolder { get; set; }
        public string Notes { get; set; }
        public string ZipFileNameMask { get; set; }
        public string FtpremoteMachine { get; set; }
        public bool? ZipaddDate { get; set; }
        public bool? RefreshFields { get; set; }
        public string EncryptionCertificate { get; set; }
        public string EncryptionKey { get; set; }
        public int? FileTypeId { get; set; }
        public int? Retries { get; set; }
        public bool? IsUnicode { get; set; }
        public bool? IsDataHorizontal { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? UpdateFileEncoding { get; set; }
        public string EmailRecipientsBcc { get; set; }
        public bool? OutputBlankFile { get; set; }
        public bool? RaiseError { get; set; }
        public string ExtendedProperties { get; set; }
        public bool? ReportNoFilesFound { get; set; }
        public bool? IgnoreFtp { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string HostName { get; set; }
    }
}
