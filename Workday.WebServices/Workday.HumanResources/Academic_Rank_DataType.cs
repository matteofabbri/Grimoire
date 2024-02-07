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
	public class Academic_Rank_DataType : INotifyPropertyChanged
	{
		private string idField;

		private string academic_Rank_Title_NameField;

		private string descriptionField;

		private bool emeritusField;

		private bool emeritusFieldSpecified;

		private decimal rank_OrderField;

		private bool rank_OrderFieldSpecified;

		private Job_ProfileObjectType[] job_Profile_ReferenceField;

		private Academic_Rank_MappingObjectType metadata_Academic_Rank_ReferenceField;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

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
		public string Academic_Rank_Title_Name
		{
			get
			{
				return this.academic_Rank_Title_NameField;
			}
			set
			{
				this.academic_Rank_Title_NameField = value;
				this.RaisePropertyChanged("Academic_Rank_Title_Name");
			}
		}

		[XmlElement(Order = 2)]
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
				this.RaisePropertyChanged("Description");
			}
		}

		[XmlElement(Order = 3)]
		public bool Emeritus
		{
			get
			{
				return this.emeritusField;
			}
			set
			{
				this.emeritusField = value;
				this.RaisePropertyChanged("Emeritus");
			}
		}

		[XmlIgnore]
		public bool EmeritusSpecified
		{
			get
			{
				return this.emeritusFieldSpecified;
			}
			set
			{
				this.emeritusFieldSpecified = value;
				this.RaisePropertyChanged("EmeritusSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Rank_Order
		{
			get
			{
				return this.rank_OrderField;
			}
			set
			{
				this.rank_OrderField = value;
				this.RaisePropertyChanged("Rank_Order");
			}
		}

		[XmlIgnore]
		public bool Rank_OrderSpecified
		{
			get
			{
				return this.rank_OrderFieldSpecified;
			}
			set
			{
				this.rank_OrderFieldSpecified = value;
				this.RaisePropertyChanged("Rank_OrderSpecified");
			}
		}

		[XmlElement("Job_Profile_Reference", Order = 5)]
		public Job_ProfileObjectType[] Job_Profile_Reference
		{
			get
			{
				return this.job_Profile_ReferenceField;
			}
			set
			{
				this.job_Profile_ReferenceField = value;
				this.RaisePropertyChanged("Job_Profile_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public Academic_Rank_MappingObjectType Metadata_Academic_Rank_Reference
		{
			get
			{
				return this.metadata_Academic_Rank_ReferenceField;
			}
			set
			{
				this.metadata_Academic_Rank_ReferenceField = value;
				this.RaisePropertyChanged("Metadata_Academic_Rank_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public bool Inactive
		{
			get
			{
				return this.inactiveField;
			}
			set
			{
				this.inactiveField = value;
				this.RaisePropertyChanged("Inactive");
			}
		}

		[XmlIgnore]
		public bool InactiveSpecified
		{
			get
			{
				return this.inactiveFieldSpecified;
			}
			set
			{
				this.inactiveFieldSpecified = value;
				this.RaisePropertyChanged("InactiveSpecified");
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
