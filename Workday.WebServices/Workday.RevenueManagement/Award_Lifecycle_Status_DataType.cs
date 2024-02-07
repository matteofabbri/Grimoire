using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Award_Lifecycle_Status_DataType : INotifyPropertyChanged
	{
		private string idField;

		private string award_Lifecycle_Status_NameField;

		private bool award_Lifecycle_Status_Valid_for_AwardField;

		private bool award_Lifecycle_Status_Valid_for_AwardFieldSpecified;

		private bool award_Lifecycle_Status_Valid_for_Award_LineField;

		private bool award_Lifecycle_Status_Valid_for_Award_LineFieldSpecified;

		private bool award_Lifecycle_Status_Default_for_AwardField;

		private bool award_Lifecycle_Status_Default_for_AwardFieldSpecified;

		private bool award_Lifecycle_Status_Default_for_Award_LineField;

		private bool award_Lifecycle_Status_Default_for_Award_LineFieldSpecified;

		private bool award_Lifecycle_Status_InactiveField;

		private bool award_Lifecycle_Status_InactiveFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Award_Lifecycle_Status_Name
		{
			get
			{
				return this.award_Lifecycle_Status_NameField;
			}
			set
			{
				this.award_Lifecycle_Status_NameField = value;
				this.RaisePropertyChanged("Award_Lifecycle_Status_Name");
			}
		}

		[XmlElement(Order = 2)]
		public bool Award_Lifecycle_Status_Valid_for_Award
		{
			get
			{
				return this.award_Lifecycle_Status_Valid_for_AwardField;
			}
			set
			{
				this.award_Lifecycle_Status_Valid_for_AwardField = value;
				this.RaisePropertyChanged("Award_Lifecycle_Status_Valid_for_Award");
			}
		}

		[XmlIgnore]
		public bool Award_Lifecycle_Status_Valid_for_AwardSpecified
		{
			get
			{
				return this.award_Lifecycle_Status_Valid_for_AwardFieldSpecified;
			}
			set
			{
				this.award_Lifecycle_Status_Valid_for_AwardFieldSpecified = value;
				this.RaisePropertyChanged("Award_Lifecycle_Status_Valid_for_AwardSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Award_Lifecycle_Status_Valid_for_Award_Line
		{
			get
			{
				return this.award_Lifecycle_Status_Valid_for_Award_LineField;
			}
			set
			{
				this.award_Lifecycle_Status_Valid_for_Award_LineField = value;
				this.RaisePropertyChanged("Award_Lifecycle_Status_Valid_for_Award_Line");
			}
		}

		[XmlIgnore]
		public bool Award_Lifecycle_Status_Valid_for_Award_LineSpecified
		{
			get
			{
				return this.award_Lifecycle_Status_Valid_for_Award_LineFieldSpecified;
			}
			set
			{
				this.award_Lifecycle_Status_Valid_for_Award_LineFieldSpecified = value;
				this.RaisePropertyChanged("Award_Lifecycle_Status_Valid_for_Award_LineSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public bool Award_Lifecycle_Status_Default_for_Award
		{
			get
			{
				return this.award_Lifecycle_Status_Default_for_AwardField;
			}
			set
			{
				this.award_Lifecycle_Status_Default_for_AwardField = value;
				this.RaisePropertyChanged("Award_Lifecycle_Status_Default_for_Award");
			}
		}

		[XmlIgnore]
		public bool Award_Lifecycle_Status_Default_for_AwardSpecified
		{
			get
			{
				return this.award_Lifecycle_Status_Default_for_AwardFieldSpecified;
			}
			set
			{
				this.award_Lifecycle_Status_Default_for_AwardFieldSpecified = value;
				this.RaisePropertyChanged("Award_Lifecycle_Status_Default_for_AwardSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public bool Award_Lifecycle_Status_Default_for_Award_Line
		{
			get
			{
				return this.award_Lifecycle_Status_Default_for_Award_LineField;
			}
			set
			{
				this.award_Lifecycle_Status_Default_for_Award_LineField = value;
				this.RaisePropertyChanged("Award_Lifecycle_Status_Default_for_Award_Line");
			}
		}

		[XmlIgnore]
		public bool Award_Lifecycle_Status_Default_for_Award_LineSpecified
		{
			get
			{
				return this.award_Lifecycle_Status_Default_for_Award_LineFieldSpecified;
			}
			set
			{
				this.award_Lifecycle_Status_Default_for_Award_LineFieldSpecified = value;
				this.RaisePropertyChanged("Award_Lifecycle_Status_Default_for_Award_LineSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public bool Award_Lifecycle_Status_Inactive
		{
			get
			{
				return this.award_Lifecycle_Status_InactiveField;
			}
			set
			{
				this.award_Lifecycle_Status_InactiveField = value;
				this.RaisePropertyChanged("Award_Lifecycle_Status_Inactive");
			}
		}

		[XmlIgnore]
		public bool Award_Lifecycle_Status_InactiveSpecified
		{
			get
			{
				return this.award_Lifecycle_Status_InactiveFieldSpecified;
			}
			set
			{
				this.award_Lifecycle_Status_InactiveFieldSpecified = value;
				this.RaisePropertyChanged("Award_Lifecycle_Status_InactiveSpecified");
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
