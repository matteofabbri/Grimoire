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
	public class Related_Person_DataType : INotifyPropertyChanged
	{
		private Related_Person_Descriptor_DataType related_Person_Descriptor_DataField;

		private Person_DataType person_DataField;

		private External_Contact_DataType external_Contact_DataField;

		private Emergency_Contact_Data_WWSType emergency_Contact_DataField;

		private Beneficiary_Data_WWSType beneficiary_DataField;

		private Dependent_Data_WWSType dependent_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Related_Person_Descriptor_DataType Related_Person_Descriptor_Data
		{
			get
			{
				return this.related_Person_Descriptor_DataField;
			}
			set
			{
				this.related_Person_Descriptor_DataField = value;
				this.RaisePropertyChanged("Related_Person_Descriptor_Data");
			}
		}

		[XmlElement(Order = 1)]
		public Person_DataType Person_Data
		{
			get
			{
				return this.person_DataField;
			}
			set
			{
				this.person_DataField = value;
				this.RaisePropertyChanged("Person_Data");
			}
		}

		[XmlElement(Order = 2)]
		public External_Contact_DataType External_Contact_Data
		{
			get
			{
				return this.external_Contact_DataField;
			}
			set
			{
				this.external_Contact_DataField = value;
				this.RaisePropertyChanged("External_Contact_Data");
			}
		}

		[XmlElement(Order = 3)]
		public Emergency_Contact_Data_WWSType Emergency_Contact_Data
		{
			get
			{
				return this.emergency_Contact_DataField;
			}
			set
			{
				this.emergency_Contact_DataField = value;
				this.RaisePropertyChanged("Emergency_Contact_Data");
			}
		}

		[XmlElement(Order = 4)]
		public Beneficiary_Data_WWSType Beneficiary_Data
		{
			get
			{
				return this.beneficiary_DataField;
			}
			set
			{
				this.beneficiary_DataField = value;
				this.RaisePropertyChanged("Beneficiary_Data");
			}
		}

		[XmlElement(Order = 5)]
		public Dependent_Data_WWSType Dependent_Data
		{
			get
			{
				return this.dependent_DataField;
			}
			set
			{
				this.dependent_DataField = value;
				this.RaisePropertyChanged("Dependent_Data");
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
