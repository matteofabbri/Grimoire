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
	public class Educational_Institution_w25_ID_DataType : INotifyPropertyChanged
	{
		private string postsecondary_Federal_IDField;

		private string postsecondary_IPEDS_IDField;

		private string postsecondary_Local_IDField;

		private string postsecondary_OPEID_IDField;

		private string postsecondary_Other_IDField;

		private string postsecondary_State_IDField;

		private string postsecondary_CEEB_ATP_IDField;

		private string secondary_Local_IDField;

		private string secondary_NCES_IDField;

		private string secondary_Other_IDField;

		private string secondary_State_IDField;

		private string secondary_CEEB_ATP_IDField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Postsecondary_Federal_ID
		{
			get
			{
				return this.postsecondary_Federal_IDField;
			}
			set
			{
				this.postsecondary_Federal_IDField = value;
				this.RaisePropertyChanged("Postsecondary_Federal_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Postsecondary_IPEDS_ID
		{
			get
			{
				return this.postsecondary_IPEDS_IDField;
			}
			set
			{
				this.postsecondary_IPEDS_IDField = value;
				this.RaisePropertyChanged("Postsecondary_IPEDS_ID");
			}
		}

		[XmlElement(Order = 2)]
		public string Postsecondary_Local_ID
		{
			get
			{
				return this.postsecondary_Local_IDField;
			}
			set
			{
				this.postsecondary_Local_IDField = value;
				this.RaisePropertyChanged("Postsecondary_Local_ID");
			}
		}

		[XmlElement(Order = 3)]
		public string Postsecondary_OPEID_ID
		{
			get
			{
				return this.postsecondary_OPEID_IDField;
			}
			set
			{
				this.postsecondary_OPEID_IDField = value;
				this.RaisePropertyChanged("Postsecondary_OPEID_ID");
			}
		}

		[XmlElement(Order = 4)]
		public string Postsecondary_Other_ID
		{
			get
			{
				return this.postsecondary_Other_IDField;
			}
			set
			{
				this.postsecondary_Other_IDField = value;
				this.RaisePropertyChanged("Postsecondary_Other_ID");
			}
		}

		[XmlElement(Order = 5)]
		public string Postsecondary_State_ID
		{
			get
			{
				return this.postsecondary_State_IDField;
			}
			set
			{
				this.postsecondary_State_IDField = value;
				this.RaisePropertyChanged("Postsecondary_State_ID");
			}
		}

		[XmlElement(Order = 6)]
		public string Postsecondary_CEEB_ATP_ID
		{
			get
			{
				return this.postsecondary_CEEB_ATP_IDField;
			}
			set
			{
				this.postsecondary_CEEB_ATP_IDField = value;
				this.RaisePropertyChanged("Postsecondary_CEEB_ATP_ID");
			}
		}

		[XmlElement(Order = 7)]
		public string Secondary_Local_ID
		{
			get
			{
				return this.secondary_Local_IDField;
			}
			set
			{
				this.secondary_Local_IDField = value;
				this.RaisePropertyChanged("Secondary_Local_ID");
			}
		}

		[XmlElement(Order = 8)]
		public string Secondary_NCES_ID
		{
			get
			{
				return this.secondary_NCES_IDField;
			}
			set
			{
				this.secondary_NCES_IDField = value;
				this.RaisePropertyChanged("Secondary_NCES_ID");
			}
		}

		[XmlElement(Order = 9)]
		public string Secondary_Other_ID
		{
			get
			{
				return this.secondary_Other_IDField;
			}
			set
			{
				this.secondary_Other_IDField = value;
				this.RaisePropertyChanged("Secondary_Other_ID");
			}
		}

		[XmlElement(Order = 10)]
		public string Secondary_State_ID
		{
			get
			{
				return this.secondary_State_IDField;
			}
			set
			{
				this.secondary_State_IDField = value;
				this.RaisePropertyChanged("Secondary_State_ID");
			}
		}

		[XmlElement(Order = 11)]
		public string Secondary_CEEB_ATP_ID
		{
			get
			{
				return this.secondary_CEEB_ATP_IDField;
			}
			set
			{
				this.secondary_CEEB_ATP_IDField = value;
				this.RaisePropertyChanged("Secondary_CEEB_ATP_ID");
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
