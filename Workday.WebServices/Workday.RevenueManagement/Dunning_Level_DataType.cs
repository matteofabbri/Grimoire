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
	public class Dunning_Level_DataType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType dunning_Level_ReferenceField;

		private string dunning_Level_NameField;

		private decimal from_DaysField;

		private bool from_DaysFieldSpecified;

		private decimal to_DaysField;

		private bool to_DaysFieldSpecified;

		private decimal from_Risk_ScoreField;

		private bool from_Risk_ScoreFieldSpecified;

		private decimal to_Risk_ScoreField;

		private bool to_Risk_ScoreFieldSpecified;

		private Business_Form_LayoutObjectType business_Form_Layout_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Dunning_Level_Reference
		{
			get
			{
				return this.dunning_Level_ReferenceField;
			}
			set
			{
				this.dunning_Level_ReferenceField = value;
				this.RaisePropertyChanged("Dunning_Level_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Dunning_Level_Name
		{
			get
			{
				return this.dunning_Level_NameField;
			}
			set
			{
				this.dunning_Level_NameField = value;
				this.RaisePropertyChanged("Dunning_Level_Name");
			}
		}

		[XmlElement(Order = 2)]
		public decimal From_Days
		{
			get
			{
				return this.from_DaysField;
			}
			set
			{
				this.from_DaysField = value;
				this.RaisePropertyChanged("From_Days");
			}
		}

		[XmlIgnore]
		public bool From_DaysSpecified
		{
			get
			{
				return this.from_DaysFieldSpecified;
			}
			set
			{
				this.from_DaysFieldSpecified = value;
				this.RaisePropertyChanged("From_DaysSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal To_Days
		{
			get
			{
				return this.to_DaysField;
			}
			set
			{
				this.to_DaysField = value;
				this.RaisePropertyChanged("To_Days");
			}
		}

		[XmlIgnore]
		public bool To_DaysSpecified
		{
			get
			{
				return this.to_DaysFieldSpecified;
			}
			set
			{
				this.to_DaysFieldSpecified = value;
				this.RaisePropertyChanged("To_DaysSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public decimal From_Risk_Score
		{
			get
			{
				return this.from_Risk_ScoreField;
			}
			set
			{
				this.from_Risk_ScoreField = value;
				this.RaisePropertyChanged("From_Risk_Score");
			}
		}

		[XmlIgnore]
		public bool From_Risk_ScoreSpecified
		{
			get
			{
				return this.from_Risk_ScoreFieldSpecified;
			}
			set
			{
				this.from_Risk_ScoreFieldSpecified = value;
				this.RaisePropertyChanged("From_Risk_ScoreSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public decimal To_Risk_Score
		{
			get
			{
				return this.to_Risk_ScoreField;
			}
			set
			{
				this.to_Risk_ScoreField = value;
				this.RaisePropertyChanged("To_Risk_Score");
			}
		}

		[XmlIgnore]
		public bool To_Risk_ScoreSpecified
		{
			get
			{
				return this.to_Risk_ScoreFieldSpecified;
			}
			set
			{
				this.to_Risk_ScoreFieldSpecified = value;
				this.RaisePropertyChanged("To_Risk_ScoreSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public Business_Form_LayoutObjectType Business_Form_Layout_Reference
		{
			get
			{
				return this.business_Form_Layout_ReferenceField;
			}
			set
			{
				this.business_Form_Layout_ReferenceField = value;
				this.RaisePropertyChanged("Business_Form_Layout_Reference");
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
