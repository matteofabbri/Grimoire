using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Admissions
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Student_Application_Response_GroupType : INotifyPropertyChanged
	{
		private bool include_ReferenceField;

		private bool include_ReferenceFieldSpecified;

		private bool include_Person_DataField;

		private bool include_Person_DataFieldSpecified;

		private bool include_Friends_and_Family_DataField;

		private bool include_Friends_and_Family_DataFieldSpecified;

		private bool include_Supporting_Material_DataField;

		private bool include_Supporting_Material_DataFieldSpecified;

		private bool include_Additional_Data_In_ResponseField;

		private bool include_Additional_Data_In_ResponseFieldSpecified;

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
		public bool Include_Person_Data
		{
			get
			{
				return this.include_Person_DataField;
			}
			set
			{
				this.include_Person_DataField = value;
				this.RaisePropertyChanged("Include_Person_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Person_DataSpecified
		{
			get
			{
				return this.include_Person_DataFieldSpecified;
			}
			set
			{
				this.include_Person_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Person_DataSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public bool Include_Friends_and_Family_Data
		{
			get
			{
				return this.include_Friends_and_Family_DataField;
			}
			set
			{
				this.include_Friends_and_Family_DataField = value;
				this.RaisePropertyChanged("Include_Friends_and_Family_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Friends_and_Family_DataSpecified
		{
			get
			{
				return this.include_Friends_and_Family_DataFieldSpecified;
			}
			set
			{
				this.include_Friends_and_Family_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Friends_and_Family_DataSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Include_Supporting_Material_Data
		{
			get
			{
				return this.include_Supporting_Material_DataField;
			}
			set
			{
				this.include_Supporting_Material_DataField = value;
				this.RaisePropertyChanged("Include_Supporting_Material_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Supporting_Material_DataSpecified
		{
			get
			{
				return this.include_Supporting_Material_DataFieldSpecified;
			}
			set
			{
				this.include_Supporting_Material_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Supporting_Material_DataSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public bool Include_Additional_Data_In_Response
		{
			get
			{
				return this.include_Additional_Data_In_ResponseField;
			}
			set
			{
				this.include_Additional_Data_In_ResponseField = value;
				this.RaisePropertyChanged("Include_Additional_Data_In_Response");
			}
		}

		[XmlIgnore]
		public bool Include_Additional_Data_In_ResponseSpecified
		{
			get
			{
				return this.include_Additional_Data_In_ResponseFieldSpecified;
			}
			set
			{
				this.include_Additional_Data_In_ResponseFieldSpecified = value;
				this.RaisePropertyChanged("Include_Additional_Data_In_ResponseSpecified");
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
