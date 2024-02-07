using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Ship_To_Contact_Info_for_Issue_Purchase_Order_Outbound_Sub_ViewType : INotifyPropertyChanged
	{
		private decimal phone_Country_CodeField;

		private bool phone_Country_CodeFieldSpecified;

		private string phone_Country_Code_Alpha2Field;

		private decimal phone_Area_CodeField;

		private bool phone_Area_CodeFieldSpecified;

		private string phone_NumberField;

		private decimal fax_Country_CodeField;

		private bool fax_Country_CodeFieldSpecified;

		private string fax_Country_Code_Alpha2Field;

		private decimal fax_Area_CodeField;

		private bool fax_Area_CodeFieldSpecified;

		private string fax_NumberField;

		private string emailField;

		private string deliver_ToField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Phone_Country_Code
		{
			get
			{
				return this.phone_Country_CodeField;
			}
			set
			{
				this.phone_Country_CodeField = value;
				this.RaisePropertyChanged("Phone_Country_Code");
			}
		}

		[XmlIgnore]
		public bool Phone_Country_CodeSpecified
		{
			get
			{
				return this.phone_Country_CodeFieldSpecified;
			}
			set
			{
				this.phone_Country_CodeFieldSpecified = value;
				this.RaisePropertyChanged("Phone_Country_CodeSpecified");
			}
		}

		[XmlElement("Phone_Country_Code_Alpha-2", Order = 1)]
		public string Phone_Country_Code_Alpha2
		{
			get
			{
				return this.phone_Country_Code_Alpha2Field;
			}
			set
			{
				this.phone_Country_Code_Alpha2Field = value;
				this.RaisePropertyChanged("Phone_Country_Code_Alpha2");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Phone_Area_Code
		{
			get
			{
				return this.phone_Area_CodeField;
			}
			set
			{
				this.phone_Area_CodeField = value;
				this.RaisePropertyChanged("Phone_Area_Code");
			}
		}

		[XmlIgnore]
		public bool Phone_Area_CodeSpecified
		{
			get
			{
				return this.phone_Area_CodeFieldSpecified;
			}
			set
			{
				this.phone_Area_CodeFieldSpecified = value;
				this.RaisePropertyChanged("Phone_Area_CodeSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public string Phone_Number
		{
			get
			{
				return this.phone_NumberField;
			}
			set
			{
				this.phone_NumberField = value;
				this.RaisePropertyChanged("Phone_Number");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Fax_Country_Code
		{
			get
			{
				return this.fax_Country_CodeField;
			}
			set
			{
				this.fax_Country_CodeField = value;
				this.RaisePropertyChanged("Fax_Country_Code");
			}
		}

		[XmlIgnore]
		public bool Fax_Country_CodeSpecified
		{
			get
			{
				return this.fax_Country_CodeFieldSpecified;
			}
			set
			{
				this.fax_Country_CodeFieldSpecified = value;
				this.RaisePropertyChanged("Fax_Country_CodeSpecified");
			}
		}

		[XmlElement("Fax_Country_Code_Alpha-2", Order = 5)]
		public string Fax_Country_Code_Alpha2
		{
			get
			{
				return this.fax_Country_Code_Alpha2Field;
			}
			set
			{
				this.fax_Country_Code_Alpha2Field = value;
				this.RaisePropertyChanged("Fax_Country_Code_Alpha2");
			}
		}

		[XmlElement(Order = 6)]
		public decimal Fax_Area_Code
		{
			get
			{
				return this.fax_Area_CodeField;
			}
			set
			{
				this.fax_Area_CodeField = value;
				this.RaisePropertyChanged("Fax_Area_Code");
			}
		}

		[XmlIgnore]
		public bool Fax_Area_CodeSpecified
		{
			get
			{
				return this.fax_Area_CodeFieldSpecified;
			}
			set
			{
				this.fax_Area_CodeFieldSpecified = value;
				this.RaisePropertyChanged("Fax_Area_CodeSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public string Fax_Number
		{
			get
			{
				return this.fax_NumberField;
			}
			set
			{
				this.fax_NumberField = value;
				this.RaisePropertyChanged("Fax_Number");
			}
		}

		[XmlElement(Order = 8)]
		public string Email
		{
			get
			{
				return this.emailField;
			}
			set
			{
				this.emailField = value;
				this.RaisePropertyChanged("Email");
			}
		}

		[XmlElement(Order = 9)]
		public string Deliver_To
		{
			get
			{
				return this.deliver_ToField;
			}
			set
			{
				this.deliver_ToField = value;
				this.RaisePropertyChanged("Deliver_To");
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
