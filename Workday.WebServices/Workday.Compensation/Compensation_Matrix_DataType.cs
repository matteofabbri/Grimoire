using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Compensation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Compensation_Matrix_DataType : INotifyPropertyChanged
	{
		private string compensation_Matrix_Matrix_IDField;

		private DateTime effective_DateField;

		private bool effective_DateFieldSpecified;

		private string compensation_Matrix_NameField;

		private string compensation_Matrix_DescriptionField;

		private Review_Rating_ScaleObjectType rating_Scale_ReferenceField;

		private object[] itemsField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Compensation_Matrix_Matrix_ID
		{
			get
			{
				return this.compensation_Matrix_Matrix_IDField;
			}
			set
			{
				this.compensation_Matrix_Matrix_IDField = value;
				this.RaisePropertyChanged("Compensation_Matrix_Matrix_ID");
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

		[XmlIgnore]
		public bool Effective_DateSpecified
		{
			get
			{
				return this.effective_DateFieldSpecified;
			}
			set
			{
				this.effective_DateFieldSpecified = value;
				this.RaisePropertyChanged("Effective_DateSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public string Compensation_Matrix_Name
		{
			get
			{
				return this.compensation_Matrix_NameField;
			}
			set
			{
				this.compensation_Matrix_NameField = value;
				this.RaisePropertyChanged("Compensation_Matrix_Name");
			}
		}

		[XmlElement(Order = 3)]
		public string Compensation_Matrix_Description
		{
			get
			{
				return this.compensation_Matrix_DescriptionField;
			}
			set
			{
				this.compensation_Matrix_DescriptionField = value;
				this.RaisePropertyChanged("Compensation_Matrix_Description");
			}
		}

		[XmlElement(Order = 4)]
		public Review_Rating_ScaleObjectType Rating_Scale_Reference
		{
			get
			{
				return this.rating_Scale_ReferenceField;
			}
			set
			{
				this.rating_Scale_ReferenceField = value;
				this.RaisePropertyChanged("Rating_Scale_Reference");
			}
		}

		[XmlElement("Compensation_Matrix_Amount_Based_Data", typeof(Compensation_Matrix_Amount_Based_DataType), Order = 5), XmlElement("Compensation_Matrix_Non-weighted_Percent_Based_Data", typeof(Compensation_Matrix_Nonweighted_Percent_Based_DataType), Order = 5), XmlElement("Compensation_Matrix_for_Weighted_Percent_Based_Data", typeof(Compensation_Matrix_Weighted_Percent_Based_DataType), Order = 5)]
		public object[] Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
				this.RaisePropertyChanged("Items");
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
