using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.SettlementServices
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Payment_Acknowledgement_Message_RequestType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType payment_Acknowledgement_Message_ReferenceField;

		private Payment_Acknowledgement_Message_DataType payment_Acknowledgement_Message_DataField;

		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Payment_Acknowledgement_Message_Reference
		{
			get
			{
				return this.payment_Acknowledgement_Message_ReferenceField;
			}
			set
			{
				this.payment_Acknowledgement_Message_ReferenceField = value;
				this.RaisePropertyChanged("Payment_Acknowledgement_Message_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Payment_Acknowledgement_Message_DataType Payment_Acknowledgement_Message_Data
		{
			get
			{
				return this.payment_Acknowledgement_Message_DataField;
			}
			set
			{
				this.payment_Acknowledgement_Message_DataField = value;
				this.RaisePropertyChanged("Payment_Acknowledgement_Message_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Add_Only
		{
			get
			{
				return this.add_OnlyField;
			}
			set
			{
				this.add_OnlyField = value;
				this.RaisePropertyChanged("Add_Only");
			}
		}

		[XmlIgnore]
		public bool Add_OnlySpecified
		{
			get
			{
				return this.add_OnlyFieldSpecified;
			}
			set
			{
				this.add_OnlyFieldSpecified = value;
				this.RaisePropertyChanged("Add_OnlySpecified");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
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
