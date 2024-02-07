using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Create_Named_Professorship_DataType : INotifyPropertyChanged
	{
		private General_Event_SubcategoryObjectType reason_ReferenceField;

		private string named_Professorship_IDField;

		private DateTime initially_Established_DateField;

		private DateTime initially_Available_DateField;

		private bool initially_Available_DateFieldSpecified;

		private bool include_Code_in_Display_NameField;

		private bool include_Code_in_Display_NameFieldSpecified;

		private Named_Professorship_Snapshot_DataType named_Professorship_Snapshot_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public General_Event_SubcategoryObjectType Reason_Reference
		{
			get
			{
				return this.reason_ReferenceField;
			}
			set
			{
				this.reason_ReferenceField = value;
				this.RaisePropertyChanged("Reason_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Named_Professorship_ID
		{
			get
			{
				return this.named_Professorship_IDField;
			}
			set
			{
				this.named_Professorship_IDField = value;
				this.RaisePropertyChanged("Named_Professorship_ID");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Initially_Established_Date
		{
			get
			{
				return this.initially_Established_DateField;
			}
			set
			{
				this.initially_Established_DateField = value;
				this.RaisePropertyChanged("Initially_Established_Date");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Initially_Available_Date
		{
			get
			{
				return this.initially_Available_DateField;
			}
			set
			{
				this.initially_Available_DateField = value;
				this.RaisePropertyChanged("Initially_Available_Date");
			}
		}

		[XmlIgnore]
		public bool Initially_Available_DateSpecified
		{
			get
			{
				return this.initially_Available_DateFieldSpecified;
			}
			set
			{
				this.initially_Available_DateFieldSpecified = value;
				this.RaisePropertyChanged("Initially_Available_DateSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public bool Include_Code_in_Display_Name
		{
			get
			{
				return this.include_Code_in_Display_NameField;
			}
			set
			{
				this.include_Code_in_Display_NameField = value;
				this.RaisePropertyChanged("Include_Code_in_Display_Name");
			}
		}

		[XmlIgnore]
		public bool Include_Code_in_Display_NameSpecified
		{
			get
			{
				return this.include_Code_in_Display_NameFieldSpecified;
			}
			set
			{
				this.include_Code_in_Display_NameFieldSpecified = value;
				this.RaisePropertyChanged("Include_Code_in_Display_NameSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public Named_Professorship_Snapshot_DataType Named_Professorship_Snapshot_Data
		{
			get
			{
				return this.named_Professorship_Snapshot_DataField;
			}
			set
			{
				this.named_Professorship_Snapshot_DataField = value;
				this.RaisePropertyChanged("Named_Professorship_Snapshot_Data");
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
