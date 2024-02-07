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
	public class Edit_Named_Professorship_DataType : INotifyPropertyChanged
	{
		private Named_ProfessorshipObjectType named_Professorship_ReferenceField;

		private DateTime effective_DateField;

		private General_Event_SubcategoryObjectType reason_ReferenceField;

		private bool include_Code_in_Display_NameField;

		private bool include_Code_in_Display_NameFieldSpecified;

		private DateTime initially_Available_DateField;

		private bool initially_Available_DateFieldSpecified;

		private DateTime on_Hold_DateField;

		private bool on_Hold_DateFieldSpecified;

		private DateTime discontinued_DateField;

		private bool discontinued_DateFieldSpecified;

		private Named_Professorship_Snapshot_DataType named_Professorship_Snapshot_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Named_ProfessorshipObjectType Named_Professorship_Reference
		{
			get
			{
				return this.named_Professorship_ReferenceField;
			}
			set
			{
				this.named_Professorship_ReferenceField = value;
				this.RaisePropertyChanged("Named_Professorship_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Effective_Date
		{
			get
			{
				return this.effective_DateField;
			}
			set
			{
				this.effective_DateField = value;
				this.RaisePropertyChanged("Effective_Date");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
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

		[XmlElement(DataType = "date", Order = 4)]
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

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime On_Hold_Date
		{
			get
			{
				return this.on_Hold_DateField;
			}
			set
			{
				this.on_Hold_DateField = value;
				this.RaisePropertyChanged("On_Hold_Date");
			}
		}

		[XmlIgnore]
		public bool On_Hold_DateSpecified
		{
			get
			{
				return this.on_Hold_DateFieldSpecified;
			}
			set
			{
				this.on_Hold_DateFieldSpecified = value;
				this.RaisePropertyChanged("On_Hold_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime Discontinued_Date
		{
			get
			{
				return this.discontinued_DateField;
			}
			set
			{
				this.discontinued_DateField = value;
				this.RaisePropertyChanged("Discontinued_Date");
			}
		}

		[XmlIgnore]
		public bool Discontinued_DateSpecified
		{
			get
			{
				return this.discontinued_DateFieldSpecified;
			}
			set
			{
				this.discontinued_DateFieldSpecified = value;
				this.RaisePropertyChanged("Discontinued_DateSpecified");
			}
		}

		[XmlElement(Order = 7)]
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
