[AID_VENDOR_QCOM_DIAG]
value:2950

[AID_VENDOR_RFS]
value:2951

[AID_VENDOR_RFS_SHARED]
value:2952

[AID_VENDOR_AID_IDD]
value: 2987

[AID_VENDOR_AID_UPDATEMISCTA]
value: 2991

[AID_VENDOR_AID_TRIMAREA]
value: 2993

[AID_VENDOR_AID_CREDMGR_CLI]
value: 2996

[AID_VENDOR_AID_TAD]
value: 2997

[AID_VENDOR_AID_TA_QMI]
value: 2998

[system/bin/qmuxd]
mode: 0700
user: AID_RADIO
group: AID_SHELL
caps: BLOCK_SUSPEND

[system/vendor/bin/mm-qcamera-daemon]
mode: 0700
user: AID_CAMERA
group: AID_SHELL
caps: SYS_NICE

[firmware/]
mode: 0771
user: AID_SYSTEM
group: AID_SYSTEM
caps: 0

[persist/]
mode: 0771
user: AID_SYSTEM
group: AID_SYSTEM
caps: 0
