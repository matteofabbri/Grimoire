using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Student_Course_Material_DataType : INotifyPropertyChanged
	{
		private string idField;

		private string student_Course_Material_TitleField;

		private string student_Course_Material_AuthorField;

		private string student_Course_Material_EditionField;

		private string student_Course_Material_PublisherField;

		private DateTime student_Course_Material_Copyright_DateField;

		private bool student_Course_Material_Copyright_DateFieldSpecified;

		private string student_Course_Material_ISBNField;

		private decimal student_Course_Material_Retail_PriceField;

		private CurrencyObjectType currency_ReferenceField;

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
		public string Student_Course_Material_Title
		{
			get
			{
				return this.student_Course_Material_TitleField;
			}
			set
			{
				this.student_Course_Material_TitleField = value;
				this.RaisePropertyChanged("Student_Course_Material_Title");
			}
		}

		[XmlElement(Order = 2)]
		public string Student_Course_Material_Author
		{
			get
			{
				return this.student_Course_Material_AuthorField;
			}
			set
			{
				this.student_Course_Material_AuthorField = value;
				this.RaisePropertyChanged("Student_Course_Material_Author");
			}
		}

		[XmlElement(Order = 3)]
		public string Student_Course_Material_Edition
		{
			get
			{
				return this.student_Course_Material_EditionField;
			}
			set
			{
				this.student_Course_Material_EditionField = value;
				this.RaisePropertyChanged("Student_Course_Material_Edition");
			}
		}

		[XmlElement(Order = 4)]
		public string Student_Course_Material_Publisher
		{
			get
			{
				return this.student_Course_Material_PublisherField;
			}
			set
			{
				this.student_Course_Material_PublisherField = value;
				this.RaisePropertyChanged("Student_Course_Material_Publisher");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Student_Course_Material_Copyright_Date
		{
			get
			{
				return this.student_Course_Material_Copyright_DateField;
			}
			set
			{
				this.student_Course_Material_Copyright_DateField = value;
				this.RaisePropertyChanged("Student_Course_Material_Copyright_Date");
			}
		}

		[XmlIgnore]
		public bool Student_Course_Material_Copyright_DateSpecified
		{
			get
			{
				return this.student_Course_Material_Copyright_DateFieldSpecified;
			}
			set
			{
				this.student_Course_Material_Copyright_DateFieldSpecified = value;
				this.RaisePropertyChanged("Student_Course_Material_Copyright_DateSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public string Student_Course_Material_ISBN
		{
			get
			{
				return this.student_Course_Material_ISBNField;
			}
			set
			{
				this.student_Course_Material_ISBNField = value;
				this.RaisePropertyChanged("Student_Course_Material_ISBN");
			}
		}

		[XmlElement(Order = 7)]
		public decimal Student_Course_Material_Retail_Price
		{
			get
			{
				return this.student_Course_Material_Retail_PriceField;
			}
			set
			{
				this.student_Course_Material_Retail_PriceField = value;
				this.RaisePropertyChanged("Student_Course_Material_Retail_Price");
			}
		}

		[XmlElement(Order = 8)]
		public CurrencyObjectType Currency_Reference
		{
			get
			{
				return this.currency_ReferenceField;
			}
			set
			{
				this.currency_ReferenceField = value;
				this.RaisePropertyChanged("Currency_Reference");
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
