using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Secondary_Educational_Institution_DataType : INotifyPropertyChanged
	{
		private string educational_Institution_Secondary_CEEB_ATP_IDField;

		private string educational_Institution_Secondary_NCES_IDField;

		private string educational_Institution_Secondary_State_IDField;

		private string educational_Institution_Secondary_Local_IDField;

		private string educational_Institution_Secondary_Other_IDField;

		private Educational_Institution_DistrictObjectType educational_Institution_Secondary_District_ReferenceField;

		private Educational_Institution_Grade_OfferedObjectType[] educational_Institution_Secondary_Grade_Offered_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Educational_Institution_Secondary_CEEB_ATP_ID
		{
			get
			{
				return this.educational_Institution_Secondary_CEEB_ATP_IDField;
			}
			set
			{
				this.educational_Institution_Secondary_CEEB_ATP_IDField = value;
				this.RaisePropertyChanged("Educational_Institution_Secondary_CEEB_ATP_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Educational_Institution_Secondary_NCES_ID
		{
			get
			{
				return this.educational_Institution_Secondary_NCES_IDField;
			}
			set
			{
				this.educational_Institution_Secondary_NCES_IDField = value;
				this.RaisePropertyChanged("Educational_Institution_Secondary_NCES_ID");
			}
		}

		[XmlElement(Order = 2)]
		public string Educational_Institution_Secondary_State_ID
		{
			get
			{
				return this.educational_Institution_Secondary_State_IDField;
			}
			set
			{
				this.educational_Institution_Secondary_State_IDField = value;
				this.RaisePropertyChanged("Educational_Institution_Secondary_State_ID");
			}
		}

		[XmlElement(Order = 3)]
		public string Educational_Institution_Secondary_Local_ID
		{
			get
			{
				return this.educational_Institution_Secondary_Local_IDField;
			}
			set
			{
				this.educational_Institution_Secondary_Local_IDField = value;
				this.RaisePropertyChanged("Educational_Institution_Secondary_Local_ID");
			}
		}

		[XmlElement(Order = 4)]
		public string Educational_Institution_Secondary_Other_ID
		{
			get
			{
				return this.educational_Institution_Secondary_Other_IDField;
			}
			set
			{
				this.educational_Institution_Secondary_Other_IDField = value;
				this.RaisePropertyChanged("Educational_Institution_Secondary_Other_ID");
			}
		}

		[XmlElement(Order = 5)]
		public Educational_Institution_DistrictObjectType Educational_Institution_Secondary_District_Reference
		{
			get
			{
				return this.educational_Institution_Secondary_District_ReferenceField;
			}
			set
			{
				this.educational_Institution_Secondary_District_ReferenceField = value;
				this.RaisePropertyChanged("Educational_Institution_Secondary_District_Reference");
			}
		}

		[XmlElement("Educational_Institution_Secondary_Grade_Offered_Reference", Order = 6)]
		public Educational_Institution_Grade_OfferedObjectType[] Educational_Institution_Secondary_Grade_Offered_Reference
		{
			get
			{
				return this.educational_Institution_Secondary_Grade_Offered_ReferenceField;
			}
			set
			{
				this.educational_Institution_Secondary_Grade_Offered_ReferenceField = value;
				this.RaisePropertyChanged("Educational_Institution_Secondary_Grade_Offered_Reference");
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
