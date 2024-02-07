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
	public class Postsecondary_Educational_Institution_DataType : INotifyPropertyChanged
	{
		private string educational_Institution_Postsecondary_CEEB_ATP_IDField;

		private string educational_Institution_Postsecondary_IPEDS_IDField;

		private string educational_Institution_Postsecondary_OPEID_IDField;

		private string educational_Institution_Postsecondary_Federal_IDField;

		private string educational_Institution_Postsecondary_State_IDField;

		private string educational_Institution_Postsecondary_Local_IDField;

		private string educational_Institution_Postsecondary_Other_IDField;

		private Educational_Institution_Carnegie_ClassificationObjectType educational_Institution_Postsecondary_Carnegie_Classification_ReferenceField;

		private Educational_Institution_Postsecondary_Award_Levels_OfferedObjectType[] educational_Institution_Postsecondary_Award_Levels_Offered_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Educational_Institution_Postsecondary_CEEB_ATP_ID
		{
			get
			{
				return this.educational_Institution_Postsecondary_CEEB_ATP_IDField;
			}
			set
			{
				this.educational_Institution_Postsecondary_CEEB_ATP_IDField = value;
				this.RaisePropertyChanged("Educational_Institution_Postsecondary_CEEB_ATP_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Educational_Institution_Postsecondary_IPEDS_ID
		{
			get
			{
				return this.educational_Institution_Postsecondary_IPEDS_IDField;
			}
			set
			{
				this.educational_Institution_Postsecondary_IPEDS_IDField = value;
				this.RaisePropertyChanged("Educational_Institution_Postsecondary_IPEDS_ID");
			}
		}

		[XmlElement(Order = 2)]
		public string Educational_Institution_Postsecondary_OPEID_ID
		{
			get
			{
				return this.educational_Institution_Postsecondary_OPEID_IDField;
			}
			set
			{
				this.educational_Institution_Postsecondary_OPEID_IDField = value;
				this.RaisePropertyChanged("Educational_Institution_Postsecondary_OPEID_ID");
			}
		}

		[XmlElement(Order = 3)]
		public string Educational_Institution_Postsecondary_Federal_ID
		{
			get
			{
				return this.educational_Institution_Postsecondary_Federal_IDField;
			}
			set
			{
				this.educational_Institution_Postsecondary_Federal_IDField = value;
				this.RaisePropertyChanged("Educational_Institution_Postsecondary_Federal_ID");
			}
		}

		[XmlElement(Order = 4)]
		public string Educational_Institution_Postsecondary_State_ID
		{
			get
			{
				return this.educational_Institution_Postsecondary_State_IDField;
			}
			set
			{
				this.educational_Institution_Postsecondary_State_IDField = value;
				this.RaisePropertyChanged("Educational_Institution_Postsecondary_State_ID");
			}
		}

		[XmlElement(Order = 5)]
		public string Educational_Institution_Postsecondary_Local_ID
		{
			get
			{
				return this.educational_Institution_Postsecondary_Local_IDField;
			}
			set
			{
				this.educational_Institution_Postsecondary_Local_IDField = value;
				this.RaisePropertyChanged("Educational_Institution_Postsecondary_Local_ID");
			}
		}

		[XmlElement(Order = 6)]
		public string Educational_Institution_Postsecondary_Other_ID
		{
			get
			{
				return this.educational_Institution_Postsecondary_Other_IDField;
			}
			set
			{
				this.educational_Institution_Postsecondary_Other_IDField = value;
				this.RaisePropertyChanged("Educational_Institution_Postsecondary_Other_ID");
			}
		}

		[XmlElement(Order = 7)]
		public Educational_Institution_Carnegie_ClassificationObjectType Educational_Institution_Postsecondary_Carnegie_Classification_Reference
		{
			get
			{
				return this.educational_Institution_Postsecondary_Carnegie_Classification_ReferenceField;
			}
			set
			{
				this.educational_Institution_Postsecondary_Carnegie_Classification_ReferenceField = value;
				this.RaisePropertyChanged("Educational_Institution_Postsecondary_Carnegie_Classification_Reference");
			}
		}

		[XmlElement("Educational_Institution_Postsecondary_Award_Levels_Offered_Reference", Order = 8)]
		public Educational_Institution_Postsecondary_Award_Levels_OfferedObjectType[] Educational_Institution_Postsecondary_Award_Levels_Offered_Reference
		{
			get
			{
				return this.educational_Institution_Postsecondary_Award_Levels_Offered_ReferenceField;
			}
			set
			{
				this.educational_Institution_Postsecondary_Award_Levels_Offered_ReferenceField = value;
				this.RaisePropertyChanged("Educational_Institution_Postsecondary_Award_Levels_Offered_Reference");
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
