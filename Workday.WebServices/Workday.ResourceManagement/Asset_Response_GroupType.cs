using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Asset_Response_GroupType : INotifyPropertyChanged
	{
		private bool include_ReferenceField;

		private bool include_ReferenceFieldSpecified;

		private bool include_Custodian_DataField;

		private bool include_Custodian_DataFieldSpecified;

		private bool include_Depreciation_DataField;

		private bool include_Depreciation_DataFieldSpecified;

		private bool include_Depreciation_Detail_DataField;

		private bool include_Depreciation_Detail_DataFieldSpecified;

		private bool include_Disposal_DataField;

		private bool include_Disposal_DataFieldSpecified;

		private bool include_Intercompany_Transfer_DataField;

		private bool include_Intercompany_Transfer_DataFieldSpecified;

		private bool include_Impairment_DataField;

		private bool include_Impairment_DataFieldSpecified;

		private bool include_Reinstatement_DataField;

		private bool include_Reinstatement_DataFieldSpecified;

		private bool include_In_Service_Schedule_DataField;

		private bool include_In_Service_Schedule_DataFieldSpecified;

		private bool include_Cost_Adjustment_DataField;

		private bool include_Cost_Adjustment_DataFieldSpecified;

		private bool include_Attachment_DataField;

		private bool include_Attachment_DataFieldSpecified;

		private bool include_Reclassification_DataField;

		private bool include_Reclassification_DataFieldSpecified;

		private bool include_Removal_DataField;

		private bool include_Removal_DataFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Include_Reference
		{
			get
			{
				return this.include_ReferenceField;
			}
			set
			{
				this.include_ReferenceField = value;
				this.RaisePropertyChanged("Include_Reference");
			}
		}

		[XmlIgnore]
		public bool Include_ReferenceSpecified
		{
			get
			{
				return this.include_ReferenceFieldSpecified;
			}
			set
			{
				this.include_ReferenceFieldSpecified = value;
				this.RaisePropertyChanged("Include_ReferenceSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public bool Include_Custodian_Data
		{
			get
			{
				return this.include_Custodian_DataField;
			}
			set
			{
				this.include_Custodian_DataField = value;
				this.RaisePropertyChanged("Include_Custodian_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Custodian_DataSpecified
		{
			get
			{
				return this.include_Custodian_DataFieldSpecified;
			}
			set
			{
				this.include_Custodian_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Custodian_DataSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public bool Include_Depreciation_Data
		{
			get
			{
				return this.include_Depreciation_DataField;
			}
			set
			{
				this.include_Depreciation_DataField = value;
				this.RaisePropertyChanged("Include_Depreciation_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Depreciation_DataSpecified
		{
			get
			{
				return this.include_Depreciation_DataFieldSpecified;
			}
			set
			{
				this.include_Depreciation_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Depreciation_DataSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Include_Depreciation_Detail_Data
		{
			get
			{
				return this.include_Depreciation_Detail_DataField;
			}
			set
			{
				this.include_Depreciation_Detail_DataField = value;
				this.RaisePropertyChanged("Include_Depreciation_Detail_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Depreciation_Detail_DataSpecified
		{
			get
			{
				return this.include_Depreciation_Detail_DataFieldSpecified;
			}
			set
			{
				this.include_Depreciation_Detail_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Depreciation_Detail_DataSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public bool Include_Disposal_Data
		{
			get
			{
				return this.include_Disposal_DataField;
			}
			set
			{
				this.include_Disposal_DataField = value;
				this.RaisePropertyChanged("Include_Disposal_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Disposal_DataSpecified
		{
			get
			{
				return this.include_Disposal_DataFieldSpecified;
			}
			set
			{
				this.include_Disposal_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Disposal_DataSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public bool Include_Intercompany_Transfer_Data
		{
			get
			{
				return this.include_Intercompany_Transfer_DataField;
			}
			set
			{
				this.include_Intercompany_Transfer_DataField = value;
				this.RaisePropertyChanged("Include_Intercompany_Transfer_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Intercompany_Transfer_DataSpecified
		{
			get
			{
				return this.include_Intercompany_Transfer_DataFieldSpecified;
			}
			set
			{
				this.include_Intercompany_Transfer_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Intercompany_Transfer_DataSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public bool Include_Impairment_Data
		{
			get
			{
				return this.include_Impairment_DataField;
			}
			set
			{
				this.include_Impairment_DataField = value;
				this.RaisePropertyChanged("Include_Impairment_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Impairment_DataSpecified
		{
			get
			{
				return this.include_Impairment_DataFieldSpecified;
			}
			set
			{
				this.include_Impairment_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Impairment_DataSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public bool Include_Reinstatement_Data
		{
			get
			{
				return this.include_Reinstatement_DataField;
			}
			set
			{
				this.include_Reinstatement_DataField = value;
				this.RaisePropertyChanged("Include_Reinstatement_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Reinstatement_DataSpecified
		{
			get
			{
				return this.include_Reinstatement_DataFieldSpecified;
			}
			set
			{
				this.include_Reinstatement_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Reinstatement_DataSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public bool Include_In_Service_Schedule_Data
		{
			get
			{
				return this.include_In_Service_Schedule_DataField;
			}
			set
			{
				this.include_In_Service_Schedule_DataField = value;
				this.RaisePropertyChanged("Include_In_Service_Schedule_Data");
			}
		}

		[XmlIgnore]
		public bool Include_In_Service_Schedule_DataSpecified
		{
			get
			{
				return this.include_In_Service_Schedule_DataFieldSpecified;
			}
			set
			{
				this.include_In_Service_Schedule_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_In_Service_Schedule_DataSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public bool Include_Cost_Adjustment_Data
		{
			get
			{
				return this.include_Cost_Adjustment_DataField;
			}
			set
			{
				this.include_Cost_Adjustment_DataField = value;
				this.RaisePropertyChanged("Include_Cost_Adjustment_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Cost_Adjustment_DataSpecified
		{
			get
			{
				return this.include_Cost_Adjustment_DataFieldSpecified;
			}
			set
			{
				this.include_Cost_Adjustment_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Cost_Adjustment_DataSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public bool Include_Attachment_Data
		{
			get
			{
				return this.include_Attachment_DataField;
			}
			set
			{
				this.include_Attachment_DataField = value;
				this.RaisePropertyChanged("Include_Attachment_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Attachment_DataSpecified
		{
			get
			{
				return this.include_Attachment_DataFieldSpecified;
			}
			set
			{
				this.include_Attachment_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Attachment_DataSpecified");
			}
		}

		[XmlElement(Order = 11)]
		public bool Include_Reclassification_Data
		{
			get
			{
				return this.include_Reclassification_DataField;
			}
			set
			{
				this.include_Reclassification_DataField = value;
				this.RaisePropertyChanged("Include_Reclassification_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Reclassification_DataSpecified
		{
			get
			{
				return this.include_Reclassification_DataFieldSpecified;
			}
			set
			{
				this.include_Reclassification_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Reclassification_DataSpecified");
			}
		}

		[XmlElement(Order = 12)]
		public bool Include_Removal_Data
		{
			get
			{
				return this.include_Removal_DataField;
			}
			set
			{
				this.include_Removal_DataField = value;
				this.RaisePropertyChanged("Include_Removal_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Removal_DataSpecified
		{
			get
			{
				return this.include_Removal_DataFieldSpecified;
			}
			set
			{
				this.include_Removal_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Removal_DataSpecified");
			}
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
