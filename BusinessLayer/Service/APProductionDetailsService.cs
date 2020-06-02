using BusinessLayer.Model;
using DataAccessLayer.EntityModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Service
{
    class APProductionDetailsService : IAPProductionDetailsService
    {
        public async Task<List<APProductionDtailsModel>> GetApproductionDetails()
        {
            using RTMContext db = new RTMContext();
            return await (from a in db.ApProductionDetails.AsNoTracking()
                          select new APProductionDtailsModel
                          {
                              ApproductionDetailsId=a.ApproductionDetailsId ,
                              EmailExchangeHeader=a.EmailExchangeHeader,
                              ToEmailAddress=a.ToEmailAddress,
                              ReceivedFrom=a.ReceivedFrom,
                              ReceivedTime=a.ReceivedTime,
                              Subject=a.Subject,
                              //MessageID=a.MessageID,
                              Market=a.Market,
                              SubQueue=a.SubQueue,
                              NoOfAttachment=a.NoOfAttachment,
                              NoOfTransaction=a.NoOfTransaction,
                              IndexerComments=a.IndexerComments,
                              IndexerStartTime=a.IndexerStartTime,
                              IndexerEndTime=a.IndexerEndTime,
                              IndexedBy=a.IndexedBy,
                              AssignedStatus=a.AssignedStatus,
                              AssignedUser=a.AssignedUser,
                              AssignedDateTime=a.AssignedDateTime,
                              AssignedComments=a.AssignedComments,
                              AssignedBy=a.AssignedBy,
                              CompletedDateTime=a.CompletedDateTime,
                              OnHoldStatus=a.OnHoldStatus,
                              EscalationStatus=a.EscalationStatus,
                              EscalationComments=a.EscalationComments,
                              Disposition=a.Disposition,
                              SubDisposition=a.SubDisposition,
                              Reason=a.Reason,
                              ProcessorComments=a.ProcessorComments,
                              ProcessorStartTime=a.ProcessorStartTime,
                              ProcessorEndTime=a.ProcessorEndTime,
                             // NoOfTransactions_Processor=a.NoOfTransactions_Processor,
                              Status=a.Status,
                              EmailType=a.EmailType,
                              Remarks=a.Remarks,
                              EmailState=a.EmailState,
                              ServerReceivedTime=a.ServerReceivedTime,
                              FirstTouchDate=a.FirstTouchDate,
                              InvoiceDescription=a.InvoiceDescription,
                              OnHoldReason=a.OnHoldReason,
                              OnHoldResolution=a.OnHoldResolution,
                              WronglyIndexedStatus=a.WronglyIndexedStatus,
                              WornglyIndexedComments=a.WornglyIndexedComments,
                              //VendorEmailID=a.VendorEmailID,
                              VendorPhoneNo=a.VendorPhoneNo,
                              UrgentCase=a.UrgentCase,
                              WronglyIndexedComments=a.WronglyIndexedComments,
                              SourceofStatement=a.SourceofStatement,
                              InputCategory=a.InputCategory,
                              EntityName=a.EntityName,
                              InvoiceCategory=a.InvoiceCategory,
                              //TicketID = a.TicketID


                          }).ToListAsync();
        }

        public async Task<bool> SaveContact(APProductionDtailsModel APProductionDtailsModel)
        {
            using (RTMContext db = new RTMContext())
            {
                DataAccessLayer.EntityModel.ApProductionDetails approductionDetails = db.ApProductionDetails.Where
                         (x => x.ApproductionDetailsId == APProductionDtailsModel.ApproductionDetailsId).FirstOrDefault();
                if (approductionDetails == null)
                {
                    approductionDetails = new ApProductionDetails()
                    {
                        EmailExchangeHeader = APProductionDtailsModel.EmailExchangeHeader,
                        ToEmailAddress = APProductionDtailsModel.ToEmailAddress,
                        ReceivedFrom = APProductionDtailsModel.ReceivedFrom,
                        ReceivedTime = APProductionDtailsModel.ReceivedTime,
                        Subject = APProductionDtailsModel.Subject,
                        //MessageID=APProductionDtailsModel.MessageID,
                        Market = APProductionDtailsModel.Market,
                        SubQueue = APProductionDtailsModel.SubQueue,
                        NoOfAttachment = APProductionDtailsModel.NoOfAttachment,
                        NoOfTransaction = APProductionDtailsModel.NoOfTransaction,
                        IndexerComments = APProductionDtailsModel.IndexerComments,
                        IndexerStartTime = APProductionDtailsModel.IndexerStartTime,
                        IndexerEndTime = APProductionDtailsModel.IndexerEndTime,
                        IndexedBy = APProductionDtailsModel.IndexedBy,
                        AssignedStatus = APProductionDtailsModel.AssignedStatus,
                        AssignedUser = APProductionDtailsModel.AssignedUser,
                        AssignedDateTime = APProductionDtailsModel.AssignedDateTime,
                        AssignedComments = APProductionDtailsModel.AssignedComments,
                        AssignedBy = APProductionDtailsModel.AssignedBy,
                        CompletedDateTime = APProductionDtailsModel.CompletedDateTime,
                        OnHoldStatus = APProductionDtailsModel.OnHoldStatus,
                        EscalationStatus = APProductionDtailsModel.EscalationStatus,
                        EscalationComments = APProductionDtailsModel.EscalationComments,
                        Disposition = APProductionDtailsModel.Disposition,
                        SubDisposition = APProductionDtailsModel.SubDisposition,
                        Reason = APProductionDtailsModel.Reason,
                        ProcessorComments = APProductionDtailsModel.ProcessorComments,
                        ProcessorStartTime = APProductionDtailsModel.ProcessorStartTime,
                        ProcessorEndTime = APProductionDtailsModel.ProcessorEndTime,
                        // NoOfTransactions_Processor=APProductionDtailsModel.NoOfTransactions_Processor,
                        Status = APProductionDtailsModel.Status,
                        EmailType = APProductionDtailsModel.EmailType,
                        Remarks = APProductionDtailsModel.Remarks,
                        EmailState = APProductionDtailsModel.EmailState,
                        ServerReceivedTime = APProductionDtailsModel.ServerReceivedTime,
                        FirstTouchDate = APProductionDtailsModel.FirstTouchDate,
                        InvoiceDescription = APProductionDtailsModel.InvoiceDescription,
                        OnHoldReason = APProductionDtailsModel.OnHoldReason,
                        OnHoldResolution = APProductionDtailsModel.OnHoldResolution,
                        WronglyIndexedStatus = APProductionDtailsModel.WronglyIndexedStatus,
                        WornglyIndexedComments = APProductionDtailsModel.WornglyIndexedComments,
                        //VendorEmailID=APProductionDtailsModel.VendorEmailID,
                        VendorPhoneNo = APProductionDtailsModel.VendorPhoneNo,
                        UrgentCase = APProductionDtailsModel.UrgentCase,
                        WronglyIndexedComments = APProductionDtailsModel.WronglyIndexedComments,
                        SourceofStatement = APProductionDtailsModel.SourceofStatement,
                        InputCategory = APProductionDtailsModel.InputCategory,
                        EntityName = APProductionDtailsModel.EntityName,
                        InvoiceCategory = APProductionDtailsModel.InvoiceCategory,

                    };
                    db.ApProductionDetails.Add(approductionDetails);

                }
                else
                {
                    approductionDetails.EmailExchangeHeader = APProductionDtailsModel.EmailExchangeHeader;
                        approductionDetails.ToEmailAddress = APProductionDtailsModel.ToEmailAddress;
                        approductionDetails.ReceivedFrom = APProductionDtailsModel.ReceivedFrom;
                        approductionDetails.ReceivedTime = APProductionDtailsModel.ReceivedTime;
                        approductionDetails.Subject = APProductionDtailsModel.Subject;
                        //MessageID=APProductionDtailsModel.MessageID;
                        approductionDetails.Market = APProductionDtailsModel.Market;
                        approductionDetails.SubQueue = APProductionDtailsModel.SubQueue;
                        approductionDetails.NoOfAttachment = APProductionDtailsModel.NoOfAttachment;
                        approductionDetails.NoOfTransaction = APProductionDtailsModel.NoOfTransaction;
                        approductionDetails.IndexerComments = APProductionDtailsModel.IndexerComments;
                        approductionDetails.IndexerStartTime = APProductionDtailsModel.IndexerStartTime;
                        approductionDetails.IndexerEndTime = APProductionDtailsModel.IndexerEndTime;
                        approductionDetails.IndexedBy = APProductionDtailsModel.IndexedBy;
                        approductionDetails.AssignedStatus = APProductionDtailsModel.AssignedStatus;
                        approductionDetails.AssignedUser = APProductionDtailsModel.AssignedUser;
                        approductionDetails.AssignedDateTime = APProductionDtailsModel.AssignedDateTime;
                        approductionDetails.AssignedComments = APProductionDtailsModel.AssignedComments;
                        approductionDetails.AssignedBy = APProductionDtailsModel.AssignedBy;
                        approductionDetails.CompletedDateTime = APProductionDtailsModel.CompletedDateTime;
                        approductionDetails.OnHoldStatus = APProductionDtailsModel.OnHoldStatus;
                        approductionDetails.EscalationStatus = APProductionDtailsModel.EscalationStatus;
                        approductionDetails.EscalationComments = APProductionDtailsModel.EscalationComments;
                        approductionDetails.Disposition = APProductionDtailsModel.Disposition;
                        approductionDetails.SubDisposition = APProductionDtailsModel.SubDisposition;
                        approductionDetails.Reason = APProductionDtailsModel.Reason;
                        approductionDetails.ProcessorComments = APProductionDtailsModel.ProcessorComments;
                        approductionDetails.ProcessorStartTime = APProductionDtailsModel.ProcessorStartTime;
                        approductionDetails.ProcessorEndTime = APProductionDtailsModel.ProcessorEndTime;
                        // NoOfTransactions_Processor=APProductionDtailsModel.NoOfTransactions_Processor;
                        approductionDetails.Status = APProductionDtailsModel.Status;
                        approductionDetails.EmailType = APProductionDtailsModel.EmailType;
                        approductionDetails.Remarks = APProductionDtailsModel.Remarks;
                        approductionDetails.EmailState = APProductionDtailsModel.EmailState;
                        approductionDetails.ServerReceivedTime = APProductionDtailsModel.ServerReceivedTime;
                        approductionDetails.FirstTouchDate = APProductionDtailsModel.FirstTouchDate;
                        approductionDetails.InvoiceDescription = APProductionDtailsModel.InvoiceDescription;
                        approductionDetails.OnHoldReason = APProductionDtailsModel.OnHoldReason;
                        approductionDetails.OnHoldResolution = APProductionDtailsModel.OnHoldResolution;
                        approductionDetails.WronglyIndexedStatus = APProductionDtailsModel.WronglyIndexedStatus;
                        approductionDetails.WornglyIndexedComments = APProductionDtailsModel.WornglyIndexedComments;
                        //VendorEmailID=APProductionDtailsModel.VendorEmailID;
                        approductionDetails.VendorPhoneNo = APProductionDtailsModel.VendorPhoneNo;
                        approductionDetails.UrgentCase = APProductionDtailsModel.UrgentCase;
                        approductionDetails.WronglyIndexedComments = APProductionDtailsModel.WronglyIndexedComments;
                        approductionDetails.SourceofStatement = APProductionDtailsModel.SourceofStatement;
                        approductionDetails.InputCategory = APProductionDtailsModel.InputCategory;
                        approductionDetails.EntityName = APProductionDtailsModel.EntityName;
                        approductionDetails.InvoiceCategory = APProductionDtailsModel.InvoiceCategory;
                }

                return await db.SaveChangesAsync() >= 1;
            }
        }

        public async Task<bool> DeleteContact(int ApProductionDetailsID)
        {
            using (RTMContext db = new RTMContext())
            {
                DataAccessLayer.EntityModel.ApProductionDetails apProductionDetails =
                     db.ApProductionDetails.Where(x => x.ApproductionDetailsId == ApProductionDetailsID).FirstOrDefault();
                if (apProductionDetails != null)
                {
                    db.ApProductionDetails.Remove(apProductionDetails);
                }
                return await db.SaveChangesAsync() >= 1;
            }
        }

        public Task<bool> SaveAPProductionDtails(APProductionDtailsModel ApproductionDetailsId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAPProductionDtails(decimal ApproductionDetailsId)
        {
            throw new NotImplementedException();
        }
    }
}
